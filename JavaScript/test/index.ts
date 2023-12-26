import CharacterEntityReference from '../lib/character-entity-reference';

const text = '&quot;abcdef&quot;';
const text2 = '\\';

try {
    const result = CharacterEntityReference.convertFromCharacterEntityReference(text);
    const result2 = CharacterEntityReference.convertToCharacterEntityReference(text2, true);

    console.log(result);
    console.log(result2);
} catch (error) {
    console.log(error);
}