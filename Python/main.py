from lib.character_entity_reference import CharacterEntityReference

text = "&quot;abcdef&quot;"
text2 = "\\"

try:
    result = CharacterEntityReference.convert_from_basic(text)
    result2 = CharacterEntityReference.convert_to(text2, True)

    print(result)
    print(result2)
except Exception as error:
    print(error)
