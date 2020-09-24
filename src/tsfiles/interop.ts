import PouchDB from 'pouchdb-browser';

const db = new PouchDB('fable-plus-typescript');
(async function () {
    try {
        const result = await db.get('using-ts-from-fable');
        console.log(result);
    } catch (error) {
        if (error.status === 404) {
            db.put({
                _id: 'using-ts-from-fable',
                true: true
            });
        }
    }
})()

export function includedFn(a: number, b: number): number {
    return a + b;
}