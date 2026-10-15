import { execFileSync } from 'node:child_process';
import { mkdir, writeFile } from 'node:fs/promises';
import { dirname, resolve } from 'node:path';
import { fileURLToPath } from 'node:url';

const projectRoot = resolve(dirname(fileURLToPath(import.meta.url)), '..');
const outputPath = resolve(projectRoot, 'src/data/licenses.json');

const output = execFileSync(process.execPath, ['pm', 'licenses', '--json', '--long'], {
  cwd: projectRoot,
  encoding: 'utf8',
  maxBuffer: 20 * 1024 * 1024,
});

const packagesByLicense = JSON.parse(output);

const licenses = Object.entries(packagesByLicense)
  .map(([license, packages]) => ({
    license,
    packages: packages
      .map(({ name, versions, author, description, homepage }) => ({
        name,
        versions: [...versions].sort(),
        ...(author ? { author } : {}),
        ...(description ? { description } : {}),
        ...(homepage ? { homepage } : {}),
      }))
      .sort((left, right) => left.name.localeCompare(right.name)),
  }))
  .sort((left, right) => left.license.localeCompare(right.license));

const data = {
  packageCount: licenses.reduce((count, { packages }) => count + packages.length, 0),
  licenses,
};

await mkdir(dirname(outputPath), { recursive: true });
await writeFile(outputPath, `${JSON.stringify(data, null, 2)}\n`);

console.log(`${data.packageCount} 件のパッケージのライセンス情報を ${outputPath} に出力しました`);
