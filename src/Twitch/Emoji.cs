namespace Twitch;

/// <summary>
/// Represents an emoji with various categories and predefined emoji instances.
/// </summary>
public sealed class Emoji
{
    private readonly string _unicode;

    /// <summary>
    /// Initializes a new instance of the <see cref="Emoji" /> class with the specified Unicode value.
    /// </summary>
    /// <param name="unicode">The Unicode value of the emoji.</param>
    internal Emoji(string unicode) => _unicode = unicode;

    /// <summary>
    /// Implicitly converts an <see cref="Emoji" /> object to its string representation.
    /// </summary>
    /// <param name="emoji">The <see cref="Emoji" /> object to convert.</param>
    public static implicit operator string(Emoji emoji) => emoji._unicode;

    /// <summary>
    /// Returns a string that represents the current <see cref="Emoji" /> object.
    /// </summary>
    /// <returns>A string that represents the current <see cref="Emoji" /> object.</returns>
    public override string ToString() => _unicode;

    /// <summary>
    /// Smileys & People
    /// </summary>
    public static class SmileysAndPeople
    {
        /// <summary>
        /// 😀 - GRINNING FACE
        /// </summary>
        public static readonly Emoji GrinningFace = new("\U0001F600");

        /// <summary>
        /// 😁 - GRINNING FACE WITH SMILING EYES
        /// </summary>
        public static readonly Emoji GrinningFaceWithSmilingEyes = new("\U0001F601");

        /// <summary>
        /// 😂 - FACE WITH TEARS OF JOY
        /// </summary>
        public static readonly Emoji FaceWithTearsOfJoy = new("\U0001F602");

        /// <summary>
        /// 🤣 - ROLLING ON THE FLOOR LAUGHING
        /// </summary>
        public static readonly Emoji RollingOnTheFloorLaughing = new("\U0001F923");

        /// <summary>
        /// 😃 - SMILING FACE WITH OPEN MOUTH
        /// </summary>
        public static readonly Emoji SmilingFaceWithOpenMouth = new("\U0001F603");

        /// <summary>
        /// 😄 - SMILING FACE WITH OPEN MOUTH AND SMILING EYES
        /// </summary>
        public static readonly Emoji SmilingFaceWithOpenMouthAndSmilingEyes = new("\U0001F604");

        /// <summary>
        /// 😅 - SMILING FACE WITH OPEN MOUTH AND COLD SWEAT
        /// </summary>
        public static readonly Emoji SmilingFaceWithOpenMouthAndColdSweat = new("\U0001F605");

        /// <summary>
        /// 😆 - SMILING FACE WITH OPEN MOUTH AND TIGHTLY-CLOSED EYES
        /// </summary>
        public static readonly Emoji SmilingFaceWithOpenMouthAndTightlyClosedEyes = new("\U0001F606");

        /// <summary>
        /// 😉 - WINKING FACE
        /// </summary>
        public static readonly Emoji WinkingFace = new("\U0001F609");

        /// <summary>
        /// 😊 - SMILING FACE WITH SMILING EYES
        /// </summary>
        public static readonly Emoji SmilingFaceWithSmilingEyes = new("\U0001F60A");

        /// <summary>
        /// 😋 - FACE SAVOURING DELICIOUS FOOD
        /// </summary>
        public static readonly Emoji FaceSavouringDeliciousFood = new("\U0001F60B");

        /// <summary>
        /// 😎 - SMILING FACE WITH SUNGLASSES
        /// </summary>
        public static readonly Emoji SmilingFaceWithSunglasses = new("\U0001F60E");

        /// <summary>
        /// 😍 - SMILING FACE WITH HEART-SHAPED EYES
        /// </summary>
        public static readonly Emoji SmilingFaceWithHeartShapedEyes = new("\U0001F60D");

        /// <summary>
        /// 😘 - FACE THROWING A KISS
        /// </summary>
        public static readonly Emoji FaceThrowingAKiss = new("\U0001F618");

        /// <summary>
        /// 😗 - KISSING FACE
        /// </summary>
        public static readonly Emoji KissingFace = new("\U0001F617");

        /// <summary>
        /// 😙 - KISSING FACE WITH SMILING EYES
        /// </summary>
        public static readonly Emoji KissingFaceWithSmilingEyes = new("\U0001F619");

        /// <summary>
        /// 😚 - KISSING FACE WITH CLOSED EYES
        /// </summary>
        public static readonly Emoji KissingFaceWithClosedEyes = new("\U0001F61A");

        /// <summary>
        /// ☺ - WHITE SMILING FACE smiling face
        /// </summary>
        public static readonly Emoji WhiteSmilingFaceSmilingFace = new("\U0000263A");

        /// <summary>
        /// 🙂 - SLIGHTLY SMILING FACE
        /// </summary>
        public static readonly Emoji SlightlySmilingFace = new("\U0001F642");

        /// <summary>
        /// 🤗 - HUGGING FACE
        /// </summary>
        public static readonly Emoji HuggingFace = new("\U0001F917");

        /// <summary>
        /// 🤔 - THINKING FACE
        /// </summary>
        public static readonly Emoji ThinkingFace = new("\U0001F914");

        /// <summary>
        /// 😐 - NEUTRAL FACE
        /// </summary>
        public static readonly Emoji NeutralFace = new("\U0001F610");

        /// <summary>
        /// 😑 - EXPRESSIONLESS FACE
        /// </summary>
        public static readonly Emoji ExpressionlessFace = new("\U0001F611");

        /// <summary>
        /// 😶 - FACE WITHOUT MOUTH
        /// </summary>
        public static readonly Emoji FaceWithoutMouth = new("\U0001F636");

        /// <summary>
        /// 🙄 - FACE WITH ROLLING EYES
        /// </summary>
        public static readonly Emoji FaceWithRollingEyes = new("\U0001F644");

        /// <summary>
        /// 😏 - SMIRKING FACE
        /// </summary>
        public static readonly Emoji SmirkingFace = new("\U0001F60F");

        /// <summary>
        /// 😣 - PERSEVERING FACE
        /// </summary>
        public static readonly Emoji PerseveringFace = new("\U0001F623");

        /// <summary>
        /// 😥 - DISAPPOINTED BUT RELIEVED FACE
        /// </summary>
        public static readonly Emoji DisappointedButRelievedFace = new("\U0001F625");

        /// <summary>
        /// 😮 - FACE WITH OPEN MOUTH
        /// </summary>
        public static readonly Emoji FaceWithOpenMouth = new("\U0001F62E");

        /// <summary>
        /// 🤐 - ZIPPER-MOUTH FACE
        /// </summary>
        public static readonly Emoji ZipperMouthFace = new("\U0001F910");

        /// <summary>
        /// 😯 - HUSHED FACE
        /// </summary>
        public static readonly Emoji HushedFace = new("\U0001F62F");

        /// <summary>
        /// 😪 - SLEEPY FACE
        /// </summary>
        public static readonly Emoji SleepyFace = new("\U0001F62A");

        /// <summary>
        /// 😫 - TIRED FACE
        /// </summary>
        public static readonly Emoji TiredFace = new("\U0001F62B");

        /// <summary>
        /// 😴 - SLEEPING FACE
        /// </summary>
        public static readonly Emoji SleepingFace = new("\U0001F634");

        /// <summary>
        /// 😌 - RELIEVED FACE
        /// </summary>
        public static readonly Emoji RelievedFace = new("\U0001F60C");

        /// <summary>
        /// 🤓 - NERD FACE
        /// </summary>
        public static readonly Emoji NerdFace = new("\U0001F913");

        /// <summary>
        /// 😛 - FACE WITH STUCK-OUT TONGUE
        /// </summary>
        public static readonly Emoji FaceWithStuckOutTongue = new("\U0001F61B");

        /// <summary>
        /// 😜 - FACE WITH STUCK-OUT TONGUE AND WINKING EYE
        /// </summary>
        public static readonly Emoji FaceWithStuckOutTongueAndWinkingEye = new("\U0001F61C");

        /// <summary>
        /// 😝 - FACE WITH STUCK-OUT TONGUE AND TIGHTLY-CLOSED EYES
        /// </summary>
        public static readonly Emoji FaceWithStuckOutTongueAndTightlyClosedEyes = new("\U0001F61D");

        /// <summary>
        /// 🤤 - DROOLING FACE
        /// </summary>
        public static readonly Emoji DroolingFace = new("\U0001F924");

        /// <summary>
        /// 😒 - UNAMUSED FACE
        /// </summary>
        public static readonly Emoji UnamusedFace = new("\U0001F612");

        /// <summary>
        /// 😓 - FACE WITH COLD SWEAT
        /// </summary>
        public static readonly Emoji FaceWithColdSweat = new("\U0001F613");

        /// <summary>
        /// 😔 - PENSIVE FACE
        /// </summary>
        public static readonly Emoji PensiveFace = new("\U0001F614");

        /// <summary>
        /// 😕 - CONFUSED FACE
        /// </summary>
        public static readonly Emoji ConfusedFace = new("\U0001F615");

        /// <summary>
        /// 🙃 - UPSIDE-DOWN FACE
        /// </summary>
        public static readonly Emoji UpsideDownFace = new("\U0001F643");

        /// <summary>
        /// 🤑 - MONEY-MOUTH FACE
        /// </summary>
        public static readonly Emoji MoneyMouthFace = new("\U0001F911");

        /// <summary>
        /// 😲 - ASTONISHED FACE
        /// </summary>
        public static readonly Emoji AstonishedFace = new("\U0001F632");

        /// <summary>
        /// ☹ - WHITE FROWNING FACE frowning face
        /// </summary>
        public static readonly Emoji WhiteFrowningFaceFrowningFace = new("\U00002639");

        /// <summary>
        /// 🙁 - SLIGHTLY FROWNING FACE
        /// </summary>
        public static readonly Emoji SlightlyFrowningFace = new("\U0001F641");

        /// <summary>
        /// 😖 - CONFOUNDED FACE
        /// </summary>
        public static readonly Emoji ConfoundedFace = new("\U0001F616");

        /// <summary>
        /// 😞 - DISAPPOINTED FACE
        /// </summary>
        public static readonly Emoji DisappointedFace = new("\U0001F61E");

        /// <summary>
        /// 😟 - WORRIED FACE
        /// </summary>
        public static readonly Emoji WorriedFace = new("\U0001F61F");

        /// <summary>
        /// 😤 - FACE WITH LOOK OF TRIUMPH face with steam from nose
        /// </summary>
        public static readonly Emoji FaceWithLookOfTriumphFaceWithSteamFromNose = new("\U0001F624");

        /// <summary>
        /// 😢 - CRYING FACE
        /// </summary>
        public static readonly Emoji CryingFace = new("\U0001F622");

        /// <summary>
        /// 😭 - LOUDLY CRYING FACE
        /// </summary>
        public static readonly Emoji LoudlyCryingFace = new("\U0001F62D");

        /// <summary>
        /// 😦 - FROWNING FACE WITH OPEN MOUTH
        /// </summary>
        public static readonly Emoji FrowningFaceWithOpenMouth = new("\U0001F626");

        /// <summary>
        /// 😧 - ANGUISHED FACE
        /// </summary>
        public static readonly Emoji AnguishedFace = new("\U0001F627");

        /// <summary>
        /// 😨 - FEARFUL FACE
        /// </summary>
        public static readonly Emoji FearfulFace = new("\U0001F628");

        /// <summary>
        /// 😩 - WEARY FACE
        /// </summary>
        public static readonly Emoji WearyFace = new("\U0001F629");

        /// <summary>
        /// 😬 - GRIMACING FACE
        /// </summary>
        public static readonly Emoji GrimacingFace = new("\U0001F62C");

        /// <summary>
        /// 😰 - FACE WITH OPEN MOUTH AND COLD SWEAT
        /// </summary>
        public static readonly Emoji FaceWithOpenMouthAndColdSweat = new("\U0001F630");

        /// <summary>
        /// 😱 - FACE SCREAMING IN FEAR
        /// </summary>
        public static readonly Emoji FaceScreamingInFear = new("\U0001F631");

        /// <summary>
        /// 😳 - FLUSHED FACE
        /// </summary>
        public static readonly Emoji FlushedFace = new("\U0001F633");

        /// <summary>
        /// 😵 - DIZZY FACE
        /// </summary>
        public static readonly Emoji DizzyFace = new("\U0001F635");

        /// <summary>
        /// 😡 - POUTING FACE
        /// </summary>
        public static readonly Emoji PoutingFace = new("\U0001F621");

        /// <summary>
        /// 😠 - ANGRY FACE
        /// </summary>
        public static readonly Emoji AngryFace = new("\U0001F620");

        /// <summary>
        /// 😇 - SMILING FACE WITH HALO
        /// </summary>
        public static readonly Emoji SmilingFaceWithHalo = new("\U0001F607");

        /// <summary>
        /// 🤠 - FACE WITH COWBOY HAT
        /// </summary>
        public static readonly Emoji FaceWithCowboyHat = new("\U0001F920");

        /// <summary>
        /// 🤡 - CLOWN FACE
        /// </summary>
        public static readonly Emoji ClownFace = new("\U0001F921");

        /// <summary>
        /// 🤥 - LYING FACE
        /// </summary>
        public static readonly Emoji LyingFace = new("\U0001F925");

        /// <summary>
        /// 😷 - FACE WITH MEDICAL MASK
        /// </summary>
        public static readonly Emoji FaceWithMedicalMask = new("\U0001F637");

        /// <summary>
        /// 🤒 - FACE WITH THERMOMETER
        /// </summary>
        public static readonly Emoji FaceWithThermometer = new("\U0001F912");

        /// <summary>
        /// 🤕 - FACE WITH HEAD-BANDAGE
        /// </summary>
        public static readonly Emoji FaceWithHeadBandage = new("\U0001F915");

        /// <summary>
        /// 🤢 - NAUSEATED FACE
        /// </summary>
        public static readonly Emoji NauseatedFace = new("\U0001F922");

        /// <summary>
        /// 🤧 - SNEEZING FACE
        /// </summary>
        public static readonly Emoji SneezingFace = new("\U0001F927");

        /// <summary>
        /// 😈 - SMILING FACE WITH HORNS
        /// </summary>
        public static readonly Emoji SmilingFaceWithHorns = new("\U0001F608");

        /// <summary>
        /// 👿 - IMP
        /// </summary>
        public static readonly Emoji Imp = new("\U0001F47F");

        /// <summary>
        /// 👹 - JAPANESE OGRE ogre
        /// </summary>
        public static readonly Emoji JapaneseOgreOgre = new("\U0001F479");

        /// <summary>
        /// 👺 - JAPANESE GOBLIN goblin
        /// </summary>
        public static readonly Emoji JapaneseGoblinGoblin = new("\U0001F47A");

        /// <summary>
        /// 💀 - SKULL
        /// </summary>
        public static readonly Emoji Skull = new("\U0001F480");

        /// <summary>
        /// ☠ - SKULL AND CROSSBONES
        /// </summary>
        public static readonly Emoji SkullAndCrossbones = new("\U00002620");

        /// <summary>
        /// 👻 - GHOST
        /// </summary>
        public static readonly Emoji Ghost = new("\U0001F47B");

        /// <summary>
        /// 👽 - EXTRATERRESTRIAL ALIEN alien
        /// </summary>
        public static readonly Emoji ExtraterrestrialAlienAlien = new("\U0001F47D");

        /// <summary>
        /// 👾 - ALIEN MONSTER
        /// </summary>
        public static readonly Emoji AlienMonster = new("\U0001F47E");

        /// <summary>
        /// 🤖 - ROBOT FACE
        /// </summary>
        public static readonly Emoji RobotFace = new("\U0001F916");

        /// <summary>
        /// 💩 - PILE OF POO
        /// </summary>
        public static readonly Emoji PileOfPoo = new("\U0001F4A9");

        /// <summary>
        /// 😺 - SMILING CAT FACE WITH OPEN MOUTH
        /// </summary>
        public static readonly Emoji SmilingCatFaceWithOpenMouth = new("\U0001F63A");

        /// <summary>
        /// 😸 - GRINNING CAT FACE WITH SMILING EYES
        /// </summary>
        public static readonly Emoji GrinningCatFaceWithSmilingEyes = new("\U0001F638");

        /// <summary>
        /// 😹 - CAT FACE WITH TEARS OF JOY
        /// </summary>
        public static readonly Emoji CatFaceWithTearsOfJoy = new("\U0001F639");

        /// <summary>
        /// 😻 - SMILING CAT FACE WITH HEART-SHAPED EYES
        /// </summary>
        public static readonly Emoji SmilingCatFaceWithHeartShapedEyes = new("\U0001F63B");

        /// <summary>
        /// 😼 - CAT FACE WITH WRY SMILE
        /// </summary>
        public static readonly Emoji CatFaceWithWrySmile = new("\U0001F63C");

        /// <summary>
        /// 😽 - KISSING CAT FACE WITH CLOSED EYES
        /// </summary>
        public static readonly Emoji KissingCatFaceWithClosedEyes = new("\U0001F63D");

        /// <summary>
        /// 🙀 - WEARY CAT FACE
        /// </summary>
        public static readonly Emoji WearyCatFace = new("\U0001F640");

        /// <summary>
        /// 😿 - CRYING CAT FACE
        /// </summary>
        public static readonly Emoji CryingCatFace = new("\U0001F63F");

        /// <summary>
        /// 😾 - POUTING CAT FACE
        /// </summary>
        public static readonly Emoji PoutingCatFace = new("\U0001F63E");

        /// <summary>
        /// 🙈 - SEE-NO-EVIL MONKEY see-no-evil
        /// </summary>
        public static readonly Emoji SeeNoEvilMonkeySeeNoEvil = new("\U0001F648");

        /// <summary>
        /// 🙉 - HEAR-NO-EVIL MONKEY hear-no-evil
        /// </summary>
        public static readonly Emoji HearNoEvilMonkeyHearNoEvil = new("\U0001F649");

        /// <summary>
        /// 🙊 - SPEAK-NO-EVIL MONKEY speak-no-evil
        /// </summary>
        public static readonly Emoji SpeakNoEvilMonkeySpeakNoEvil = new("\U0001F64A");

        /// <summary>
        /// 👦 - BOY
        /// </summary>
        public static readonly Emoji Boy = new("\U0001F466");

        /// <summary>
        /// 👧 - GIRL
        /// </summary>
        public static readonly Emoji Girl = new("\U0001F467");

        /// <summary>
        /// 👨 - MAN
        /// </summary>
        public static readonly Emoji Man = new("\U0001F468");

        /// <summary>
        /// 👩 - WOMAN
        /// </summary>
        public static readonly Emoji Woman = new("\U0001F469");

        /// <summary>
        /// 👴 - OLDER MAN old man
        /// </summary>
        public static readonly Emoji OlderManOldMan = new("\U0001F474");

        /// <summary>
        /// 👵 - OLDER WOMAN old woman
        /// </summary>
        public static readonly Emoji OlderWomanOldWoman = new("\U0001F475");

        /// <summary>
        /// 👶 - BABY
        /// </summary>
        public static readonly Emoji Baby = new("\U0001F476");

        /// <summary>
        /// 👼 - BABY ANGEL
        /// </summary>
        public static readonly Emoji BabyAngel = new("\U0001F47C");

        /// <summary>
        /// 👱 - PERSON WITH BLOND HAIR
        /// </summary>
        public static readonly Emoji PersonWithBlondHair = new("\U0001F471");

        /// <summary>
        /// 👮 - POLICE OFFICER
        /// </summary>
        public static readonly Emoji PoliceOfficer = new("\U0001F46E");

        /// <summary>
        /// 👲 - MAN WITH GUA PI MAO man with chinese cap
        /// </summary>
        public static readonly Emoji ManWithGuaPiMaoManWithChineseCap = new("\U0001F472");

        /// <summary>
        /// 👳 - MAN WITH TURBAN
        /// </summary>
        public static readonly Emoji ManWithTurban = new("\U0001F473");

        /// <summary>
        /// 👷 - CONSTRUCTION WORKER
        /// </summary>
        public static readonly Emoji ConstructionWorker = new("\U0001F477");

        /// <summary>
        /// 👸 - PRINCESS
        /// </summary>
        public static readonly Emoji Princess = new("\U0001F478");

        /// <summary>
        /// 🤴 - PRINCE
        /// </summary>
        public static readonly Emoji Prince = new("\U0001F934");

        /// <summary>
        /// 💂 - GUARDSMAN
        /// </summary>
        public static readonly Emoji Guardsman = new("\U0001F482");

        /// <summary>
        /// 🕵 - SLEUTH OR SPY detective
        /// </summary>
        public static readonly Emoji SleuthOrSpyDetective = new("\U0001F575");

        /// <summary>
        /// 🎅 - FATHER CHRISTMAS santa claus
        /// </summary>
        public static readonly Emoji FatherChristmasSantaClaus = new("\U0001F385");

        /// <summary>
        /// 🤶 - MOTHER CHRISTMAS
        /// </summary>
        public static readonly Emoji MotherChristmas = new("\U0001F936");

        /// <summary>
        /// 👰 - BRIDE WITH VEIL
        /// </summary>
        public static readonly Emoji BrideWithVeil = new("\U0001F470");

        /// <summary>
        /// 🤵 - MAN IN TUXEDO
        /// </summary>
        public static readonly Emoji ManInTuxedo = new("\U0001F935");

        /// <summary>
        /// 💆 - FACE MASSAGE
        /// </summary>
        public static readonly Emoji FaceMassage = new("\U0001F486");

        /// <summary>
        /// 💇 - HAIRCUT
        /// </summary>
        public static readonly Emoji Haircut = new("\U0001F487");

        /// <summary>
        /// 🙍 - PERSON FROWNING
        /// </summary>
        public static readonly Emoji PersonFrowning = new("\U0001F64D");

        /// <summary>
        /// 🙎 - PERSON WITH POUTING FACE person pouting
        /// </summary>
        public static readonly Emoji PersonWithPoutingFacePersonPouting = new("\U0001F64E");

        /// <summary>
        /// 🙅 - FACE WITH NO GOOD GESTURE gesturing no
        /// </summary>
        public static readonly Emoji FaceWithNoGoodGestureGesturingNo = new("\U0001F645");

        /// <summary>
        /// 🙆 - FACE WITH OK GESTURE gesturing ok
        /// </summary>
        public static readonly Emoji FaceWithOkGestureGesturingOk = new("\U0001F646");

        /// <summary>
        /// 💁 - INFORMATION DESK PERSON
        /// </summary>
        public static readonly Emoji InformationDeskPerson = new("\U0001F481");

        /// <summary>
        /// 🤷 - SHRUG
        /// </summary>
        public static readonly Emoji Shrug = new("\U0001F937");

        /// <summary>
        /// 🙋 - HAPPY PERSON RAISING ONE HAND happy person raising hand
        /// </summary>
        public static readonly Emoji HappyPersonRaisingOneHandHappyPersonRaisingHand = new("\U0001F64B");

        /// <summary>
        /// 🤦 - FACE PALM
        /// </summary>
        public static readonly Emoji FacePalm = new("\U0001F926");

        /// <summary>
        /// 🙇 - PERSON BOWING DEEPLY person bowing
        /// </summary>
        public static readonly Emoji PersonBowingDeeplyPersonBowing = new("\U0001F647");

        /// <summary>
        /// 🚶 - PEDESTRIAN
        /// </summary>
        public static readonly Emoji Pedestrian = new("\U0001F6B6");

        /// <summary>
        /// 🏃 - RUNNER
        /// </summary>
        public static readonly Emoji Runner = new("\U0001F3C3");

        /// <summary>
        /// 💃 - DANCER
        /// </summary>
        public static readonly Emoji Dancer = new("\U0001F483");

        /// <summary>
        /// 🕺 - MAN DANCING
        /// </summary>
        public static readonly Emoji ManDancing = new("\U0001F57A");

        /// <summary>
        /// 🤰 - PREGNANT WOMAN
        /// </summary>
        public static readonly Emoji PregnantWoman = new("\U0001F930");

        /// <summary>
        /// 👯 - WOMAN WITH BUNNY EARS women partying
        /// </summary>
        public static readonly Emoji WomanWithBunnyEarsWomenPartying = new("\U0001F46F");

        /// <summary>
        /// 🕴 - MAN IN BUSINESS SUIT LEVITATING
        /// </summary>
        public static readonly Emoji ManInBusinessSuitLevitating = new("\U0001F574");

        /// <summary>
        /// 🗣 - SPEAKING HEAD IN SILHOUETTE speaking head
        /// </summary>
        public static readonly Emoji SpeakingHeadInSilhouetteSpeakingHead = new("\U0001F5E3");

        /// <summary>
        /// 👤 - BUST IN SILHOUETTE
        /// </summary>
        public static readonly Emoji BustInSilhouette = new("\U0001F464");

        /// <summary>
        /// 👥 - BUSTS IN SILHOUETTE
        /// </summary>
        public static readonly Emoji BustsInSilhouette = new("\U0001F465");

        /// <summary>
        /// 👫 - MAN AND WOMAN HOLDING HANDS
        /// </summary>
        public static readonly Emoji ManAndWomanHoldingHands = new("\U0001F46B");

        /// <summary>
        /// 👬 - TWO MEN HOLDING HANDS
        /// </summary>
        public static readonly Emoji TwoMenHoldingHands = new("\U0001F46C");

        /// <summary>
        /// 👭 - TWO WOMEN HOLDING HANDS
        /// </summary>
        public static readonly Emoji TwoWomenHoldingHands = new("\U0001F46D");

        /// <summary>
        /// 💏 - KISS
        /// </summary>
        public static readonly Emoji Kiss = new("\U0001F48F");

        /// <summary>
        /// 👩‍❤️‍💋‍👨 - Kiss WOMAN And MAN
        /// </summary>
        public static readonly Emoji KissWomanAndMan = new("\U0001F469\U0000200D");

        /// <summary>
        /// 👨‍❤️‍💋‍👨 - Kiss MAN And MAN
        /// </summary>
        public static readonly Emoji KissManAndMan = new("\U0001F468\U0000200D");

        /// <summary>
        /// 👩‍❤️‍💋‍👩 - Kiss WOMAN And WOMAN
        /// </summary>
        public static readonly Emoji KissWomanAndWoman = new("\U0001F469\U0000200D");

        /// <summary>
        /// 💑 - COUPLE WITH HEART
        /// </summary>
        public static readonly Emoji CoupleWithHeart = new("\U0001F491");

        /// <summary>
        /// 👩‍❤️‍👨 - Couple with heart WOMAN And MAN
        /// </summary>
        public static readonly Emoji CoupleWithHeartWomanAndMan = new("\U0001F469\U0000200D");

        /// <summary>
        /// 👨‍❤️‍👨 - Couple with heart MAN And MAN
        /// </summary>
        public static readonly Emoji CoupleWithHeartManAndMan = new("\U0001F468\U0000200D");

        /// <summary>
        /// 👩‍❤️‍👩 - Couple with heart WOMAN And WOMAN
        /// </summary>
        public static readonly Emoji CoupleWithHeartWomanAndWoman = new("\U0001F469\U0000200D");

        /// <summary>
        /// 👪 - FAMILY
        /// </summary>
        public static readonly Emoji Family = new("\U0001F46A");

        /// <summary>
        /// 👨‍👩‍👦 - Family MAN And WOMAN And BOY
        /// </summary>
        public static readonly Emoji FamilyManAndWomanAndBoy = new("\U0001F468\U0000200D");

        /// <summary>
        /// 👨‍👩‍👧 - Family MAN And WOMAN And GIRL
        /// </summary>
        public static readonly Emoji FamilyManAndWomanAndGirl = new("\U0001F468\U0000200D");

        /// <summary>
        /// 👨‍👩‍👧‍👦 - Family MAN And WOMAN And GIRL And BOY
        /// </summary>
        public static readonly Emoji FamilyManAndWomanAndGirlAndBoy = new("\U0001F468\U0000200D");

        /// <summary>
        /// 👨‍👩‍👦‍👦 - Family MAN And WOMAN And BOY And BOY
        /// </summary>
        public static readonly Emoji FamilyManAndWomanAndBoyAndBoy = new("\U0001F468\U0000200D");

        /// <summary>
        /// 👨‍👩‍👧‍👧 - Family MAN And WOMAN And GIRL And GIRL
        /// </summary>
        public static readonly Emoji FamilyManAndWomanAndGirlAndGirl = new("\U0001F468\U0000200D");

        /// <summary>
        /// 👨‍👨‍👦 - Family MAN And MAN And BOY
        /// </summary>
        public static readonly Emoji FamilyManAndManAndBoy = new("\U0001F468\U0000200D");

        /// <summary>
        /// 👨‍👨‍👧 - Family MAN And MAN And GIRL
        /// </summary>
        public static readonly Emoji FamilyManAndManAndGirl = new("\U0001F468\U0000200D");

        /// <summary>
        /// 👨‍👨‍👧‍👦 - Family MAN And MAN And GIRL And BOY
        /// </summary>
        public static readonly Emoji FamilyManAndManAndGirlAndBoy = new("\U0001F468\U0000200D");

        /// <summary>
        /// 👨‍👨‍👦‍👦 - Family MAN And MAN And BOY And BOY
        /// </summary>
        public static readonly Emoji FamilyManAndManAndBoyAndBoy = new("\U0001F468\U0000200D");

        /// <summary>
        /// 👨‍👨‍👧‍👧 - Family MAN And MAN And GIRL And GIRL
        /// </summary>
        public static readonly Emoji FamilyManAndManAndGirlAndGirl = new("\U0001F468\U0000200D");

        /// <summary>
        /// 👩‍👩‍👦 - Family WOMAN And WOMAN And BOY
        /// </summary>
        public static readonly Emoji FamilyWomanAndWomanAndBoy = new("\U0001F469\U0000200D");

        /// <summary>
        /// 👩‍👩‍👧 - Family WOMAN And WOMAN And GIRL
        /// </summary>
        public static readonly Emoji FamilyWomanAndWomanAndGirl = new("\U0001F469\U0000200D");

        /// <summary>
        /// 👩‍👩‍👧‍👦 - Family WOMAN And WOMAN And GIRL And BOY
        /// </summary>
        public static readonly Emoji FamilyWomanAndWomanAndGirlAndBoy = new("\U0001F469\U0000200D");

        /// <summary>
        /// 👩‍👩‍👦‍👦 - Family WOMAN And WOMAN And BOY And BOY
        /// </summary>
        public static readonly Emoji FamilyWomanAndWomanAndBoyAndBoy = new("\U0001F469\U0000200D");

        /// <summary>
        /// 👩‍👩‍👧‍👧 - Family WOMAN And WOMAN And GIRL And GIRL
        /// </summary>
        public static readonly Emoji FamilyWomanAndWomanAndGirlAndGirl = new("\U0001F469\U0000200D");

        /// <summary>
        /// 🏻 - EMOJI MODIFIER FITZPATRICK TYPE-1-2 skin type-1-2
        /// </summary>
        public static readonly Emoji EmojiModifierFitzpatrickType12SkinType12 = new("\U0001F3FB");

        /// <summary>
        /// 🏼 - EMOJI MODIFIER FITZPATRICK TYPE-3 skin type-3
        /// </summary>
        public static readonly Emoji EmojiModifierFitzpatrickType3SkinType3 = new("\U0001F3FC");

        /// <summary>
        /// 🏽 - EMOJI MODIFIER FITZPATRICK TYPE-4 skin type-4
        /// </summary>
        public static readonly Emoji EmojiModifierFitzpatrickType4SkinType4 = new("\U0001F3FD");

        /// <summary>
        /// 🏾 - EMOJI MODIFIER FITZPATRICK TYPE-5 skin type-5
        /// </summary>
        public static readonly Emoji EmojiModifierFitzpatrickType5SkinType5 = new("\U0001F3FE");

        /// <summary>
        /// 🏿 - EMOJI MODIFIER FITZPATRICK TYPE-6 skin type-6
        /// </summary>
        public static readonly Emoji EmojiModifierFitzpatrickType6SkinType6 = new("\U0001F3FF");

        /// <summary>
        /// 💪 - FLEXED BICEPS
        /// </summary>
        public static readonly Emoji FlexedBiceps = new("\U0001F4AA");

        /// <summary>
        /// 🤳 - SELFIE
        /// </summary>
        public static readonly Emoji Selfie = new("\U0001F933");

        /// <summary>
        /// 👈 - WHITE LEFT POINTING BACKHAND INDEX backhand index pointing left
        /// </summary>
        public static readonly Emoji WhiteLeftPointingBackhandIndexBackhandIndexPointingLeft = new("\U0001F448");

        /// <summary>
        /// 👉 - WHITE RIGHT POINTING BACKHAND INDEX backhand index pointing right
        /// </summary>
        public static readonly Emoji WhiteRightPointingBackhandIndexBackhandIndexPointingRight = new("\U0001F449");

        /// <summary>
        /// ☝ - WHITE UP POINTING INDEX index pointing up
        /// </summary>
        public static readonly Emoji WhiteUpPointingIndexIndexPointingUp = new("\U0000261D");

        /// <summary>
        /// 👆 - WHITE UP POINTING BACKHAND INDEX backhand index pointing up
        /// </summary>
        public static readonly Emoji WhiteUpPointingBackhandIndexBackhandIndexPointingUp = new("\U0001F446");

        /// <summary>
        /// 🖕 - REVERSED HAND WITH MIDDLE FINGER EXTENDED middle finger
        /// </summary>
        public static readonly Emoji ReversedHandWithMiddleFingerExtendedMiddleFinger = new("\U0001F595");

        /// <summary>
        /// 👇 - WHITE DOWN POINTING BACKHAND INDEX backhand index pointing down
        /// </summary>
        public static readonly Emoji WhiteDownPointingBackhandIndexBackhandIndexPointingDown = new("\U0001F447");

        /// <summary>
        /// ✌ - VICTORY HAND
        /// </summary>
        public static readonly Emoji VictoryHand = new("\U0000270C");

        /// <summary>
        /// 🤞 - HAND WITH INDEX AND MIDDLE FINGERS CROSSED
        /// </summary>
        public static readonly Emoji HandWithIndexAndMiddleFingersCrossed = new("\U0001F91E");

        /// <summary>
        /// 🖖 - RAISED HAND WITH PART BETWEEN MIDDLE AND RING FINGERS vulcan salute
        /// </summary>
        public static readonly Emoji RaisedHandWithPartBetweenMiddleAndRingFingersVulcanSalute = new("\U0001F596");

        /// <summary>
        /// 🤘 - SIGN OF THE HORNS
        /// </summary>
        public static readonly Emoji SignOfTheHorns = new("\U0001F918");

        /// <summary>
        /// 🤙 - CALL ME HAND
        /// </summary>
        public static readonly Emoji CallMeHand = new("\U0001F919");

        /// <summary>
        /// 🖐 - RAISED HAND WITH FINGERS SPLAYED
        /// </summary>
        public static readonly Emoji RaisedHandWithFingersSplayed = new("\U0001F590");

        /// <summary>
        /// ✋ - RAISED HAND
        /// </summary>
        public static readonly Emoji RaisedHand = new("\U0000270B");

        /// <summary>
        /// 👌 - OK HAND SIGN ok hand
        /// </summary>
        public static readonly Emoji OkHandSignOkHand = new("\U0001F44C");

        /// <summary>
        /// 👍 - THUMBS UP SIGN thumbs up
        /// </summary>
        public static readonly Emoji ThumbsUpSignThumbsUp = new("\U0001F44D");

        /// <summary>
        /// 👎 - THUMBS DOWN SIGN thumbs down
        /// </summary>
        public static readonly Emoji ThumbsDownSignThumbsDown = new("\U0001F44E");

        /// <summary>
        /// ✊ - RAISED FIST
        /// </summary>
        public static readonly Emoji RaisedFist = new("\U0000270A");

        /// <summary>
        /// 👊 - FISTED HAND SIGN oncoming fist
        /// </summary>
        public static readonly Emoji FistedHandSignOncomingFist = new("\U0001F44A");

        /// <summary>
        /// 🤛 - LEFT-FACING FIST
        /// </summary>
        public static readonly Emoji LeftFacingFist = new("\U0001F91B");

        /// <summary>
        /// 🤜 - RIGHT-FACING FIST
        /// </summary>
        public static readonly Emoji RightFacingFist = new("\U0001F91C");

        /// <summary>
        /// 🤚 - RAISED BACK OF HAND
        /// </summary>
        public static readonly Emoji RaisedBackOfHand = new("\U0001F91A");

        /// <summary>
        /// 👋 - WAVING HAND SIGN waving hand
        /// </summary>
        public static readonly Emoji WavingHandSignWavingHand = new("\U0001F44B");

        /// <summary>
        /// 👏 - CLAPPING HANDS SIGN clapping hands
        /// </summary>
        public static readonly Emoji ClappingHandsSignClappingHands = new("\U0001F44F");

        /// <summary>
        /// ✍ - WRITING HAND
        /// </summary>
        public static readonly Emoji WritingHand = new("\U0000270D");

        /// <summary>
        /// 👐 - OPEN HANDS SIGN open hands
        /// </summary>
        public static readonly Emoji OpenHandsSignOpenHands = new("\U0001F450");

        /// <summary>
        /// 🙌 - PERSON RAISING BOTH HANDS IN CELEBRATION person raising hands
        /// </summary>
        public static readonly Emoji PersonRaisingBothHandsInCelebrationPersonRaisingHands = new("\U0001F64C");

        /// <summary>
        /// 🙏 - PERSON WITH FOLDED HANDS folded hands
        /// </summary>
        public static readonly Emoji PersonWithFoldedHandsFoldedHands = new("\U0001F64F");

        /// <summary>
        /// 🤝 - HANDSHAKE
        /// </summary>
        public static readonly Emoji Handshake = new("\U0001F91D");

        /// <summary>
        /// 💅 - NAIL POLISH
        /// </summary>
        public static readonly Emoji NailPolish = new("\U0001F485");

        /// <summary>
        /// 👂 - EAR
        /// </summary>
        public static readonly Emoji Ear = new("\U0001F442");

        /// <summary>
        /// 👃 - NOSE
        /// </summary>
        public static readonly Emoji Nose = new("\U0001F443");

        /// <summary>
        /// 👣 - FOOTPRINTS
        /// </summary>
        public static readonly Emoji Footprints = new("\U0001F463");

        /// <summary>
        /// 👀 - EYES
        /// </summary>
        public static readonly Emoji Eyes = new("\U0001F440");

        /// <summary>
        /// 👁 - EYE
        /// </summary>
        public static readonly Emoji Eye = new("\U0001F441");

        /// <summary>
        /// 👁‍🗨 - EYE And LEFT SPEECH BUBBLE eye in speech bubble
        /// </summary>
        public static readonly Emoji EyeAndLeftSpeechBubbleEyeInSpeechBubble = new("\U0001F441\U0000200D");

        /// <summary>
        /// 👅 - TONGUE
        /// </summary>
        public static readonly Emoji Tongue = new("\U0001F445");

        /// <summary>
        /// 👄 - MOUTH
        /// </summary>
        public static readonly Emoji Mouth = new("\U0001F444");

        /// <summary>
        /// 💋 - KISS MARK
        /// </summary>
        public static readonly Emoji KissMark = new("\U0001F48B");

        /// <summary>
        /// 💘 - HEART WITH ARROW
        /// </summary>
        public static readonly Emoji HeartWithArrow = new("\U0001F498");

        /// <summary>
        /// ❤ - HEAVY BLACK HEART red heart
        /// </summary>
        public static readonly Emoji HeavyBlackHeartRedHeart = new("\U00002764");

        /// <summary>
        /// 💓 - BEATING HEART
        /// </summary>
        public static readonly Emoji BeatingHeart = new("\U0001F493");

        /// <summary>
        /// 💔 - BROKEN HEART
        /// </summary>
        public static readonly Emoji BrokenHeart = new("\U0001F494");

        /// <summary>
        /// 💕 - TWO HEARTS
        /// </summary>
        public static readonly Emoji TwoHearts = new("\U0001F495");

        /// <summary>
        /// 💖 - SPARKLING HEART
        /// </summary>
        public static readonly Emoji SparklingHeart = new("\U0001F496");

        /// <summary>
        /// 💗 - GROWING HEART
        /// </summary>
        public static readonly Emoji GrowingHeart = new("\U0001F497");

        /// <summary>
        /// 💙 - BLUE HEART
        /// </summary>
        public static readonly Emoji BlueHeart = new("\U0001F499");

        /// <summary>
        /// 💚 - GREEN HEART
        /// </summary>
        public static readonly Emoji GreenHeart = new("\U0001F49A");

        /// <summary>
        /// 💛 - YELLOW HEART
        /// </summary>
        public static readonly Emoji YellowHeart = new("\U0001F49B");

        /// <summary>
        /// 💜 - PURPLE HEART
        /// </summary>
        public static readonly Emoji PurpleHeart = new("\U0001F49C");

        /// <summary>
        /// 🖤 - BLACK HEART
        /// </summary>
        public static readonly Emoji BlackHeart = new("\U0001F5A4");

        /// <summary>
        /// 💝 - HEART WITH RIBBON
        /// </summary>
        public static readonly Emoji HeartWithRibbon = new("\U0001F49D");

        /// <summary>
        /// 💞 - REVOLVING HEARTS
        /// </summary>
        public static readonly Emoji RevolvingHearts = new("\U0001F49E");

        /// <summary>
        /// 💟 - HEART DECORATION
        /// </summary>
        public static readonly Emoji HeartDecoration = new("\U0001F49F");

        /// <summary>
        /// ❣ - HEAVY HEART EXCLAMATION MARK ORNAMENT
        /// </summary>
        public static readonly Emoji HeavyHeartExclamationMarkOrnament = new("\U00002763");

        /// <summary>
        /// 💌 - LOVE LETTER
        /// </summary>
        public static readonly Emoji LoveLetter = new("\U0001F48C");

        /// <summary>
        /// 💤 - SLEEPING SYMBOL zzz
        /// </summary>
        public static readonly Emoji SleepingSymbolZzz = new("\U0001F4A4");

        /// <summary>
        /// 💢 - ANGER SYMBOL
        /// </summary>
        public static readonly Emoji AngerSymbol = new("\U0001F4A2");

        /// <summary>
        /// 💣 - BOMB
        /// </summary>
        public static readonly Emoji Bomb = new("\U0001F4A3");

        /// <summary>
        /// 💥 - COLLISION SYMBOL collision
        /// </summary>
        public static readonly Emoji CollisionSymbolCollision = new("\U0001F4A5");

        /// <summary>
        /// 💦 - SPLASHING SWEAT SYMBOL sweat droplets
        /// </summary>
        public static readonly Emoji SplashingSweatSymbolSweatDroplets = new("\U0001F4A6");

        /// <summary>
        /// 💨 - DASH SYMBOL dashing
        /// </summary>
        public static readonly Emoji DashSymbolDashing = new("\U0001F4A8");

        /// <summary>
        /// 💫 - DIZZY SYMBOL dizzy
        /// </summary>
        public static readonly Emoji DizzySymbolDizzy = new("\U0001F4AB");

        /// <summary>
        /// 💬 - SPEECH BALLOON
        /// </summary>
        public static readonly Emoji SpeechBalloon = new("\U0001F4AC");

        /// <summary>
        /// 🗨 - LEFT SPEECH BUBBLE
        /// </summary>
        public static readonly Emoji LeftSpeechBubble = new("\U0001F5E8");

        /// <summary>
        /// 🗯 - RIGHT ANGER BUBBLE
        /// </summary>
        public static readonly Emoji RightAngerBubble = new("\U0001F5EF");

        /// <summary>
        /// 💭 - THOUGHT BALLOON
        /// </summary>
        public static readonly Emoji ThoughtBalloon = new("\U0001F4AD");

        /// <summary>
        /// 🕳 - HOLE
        /// </summary>
        public static readonly Emoji Hole = new("\U0001F573");

        /// <summary>
        /// 👓 - EYEGLASSES glasses
        /// </summary>
        public static readonly Emoji EyeglassesGlasses = new("\U0001F453");

        /// <summary>
        /// 🕶 - DARK SUNGLASSES sunglasses
        /// </summary>
        public static readonly Emoji DarkSunglassesSunglasses = new("\U0001F576");

        /// <summary>
        /// 👔 - NECKTIE
        /// </summary>
        public static readonly Emoji Necktie = new("\U0001F454");

        /// <summary>
        /// 👕 - T-SHIRT
        /// </summary>
        public static readonly Emoji TShirt = new("\U0001F455");

        /// <summary>
        /// 👖 - JEANS
        /// </summary>
        public static readonly Emoji Jeans = new("\U0001F456");

        /// <summary>
        /// 👗 - DRESS
        /// </summary>
        public static readonly Emoji Dress = new("\U0001F457");

        /// <summary>
        /// 👘 - KIMONO
        /// </summary>
        public static readonly Emoji Kimono = new("\U0001F458");

        /// <summary>
        /// 👙 - BIKINI
        /// </summary>
        public static readonly Emoji Bikini = new("\U0001F459");

        /// <summary>
        /// 👚 - WOMANS CLOTHES womans clothes
        /// </summary>
        public static readonly Emoji WomansClothesWomansClothes = new("\U0001F45A");

        /// <summary>
        /// 👛 - PURSE
        /// </summary>
        public static readonly Emoji Purse = new("\U0001F45B");

        /// <summary>
        /// 👜 - HANDBAG
        /// </summary>
        public static readonly Emoji Handbag = new("\U0001F45C");

        /// <summary>
        /// 👝 - POUCH
        /// </summary>
        public static readonly Emoji Pouch = new("\U0001F45D");

        /// <summary>
        /// 🛍 - SHOPPING BAGS
        /// </summary>
        public static readonly Emoji ShoppingBags = new("\U0001F6CD");

        /// <summary>
        /// 🎒 - SCHOOL SATCHEL school backpack
        /// </summary>
        public static readonly Emoji SchoolSatchelSchoolBackpack = new("\U0001F392");

        /// <summary>
        /// 👞 - MANS SHOE mans shoe
        /// </summary>
        public static readonly Emoji MansShoeMansShoe = new("\U0001F45E");

        /// <summary>
        /// 👟 - ATHLETIC SHOE running shoe
        /// </summary>
        public static readonly Emoji AthleticShoeRunningShoe = new("\U0001F45F");

        /// <summary>
        /// 👠 - HIGH-HEELED SHOE
        /// </summary>
        public static readonly Emoji HighHeeledShoe = new("\U0001F460");

        /// <summary>
        /// 👡 - WOMANS SANDAL womans sandal
        /// </summary>
        public static readonly Emoji WomansSandalWomansSandal = new("\U0001F461");

        /// <summary>
        /// 👢 - WOMANS BOOTS womans boot
        /// </summary>
        public static readonly Emoji WomansBootsWomansBoot = new("\U0001F462");

        /// <summary>
        /// 👑 - CROWN
        /// </summary>
        public static readonly Emoji Crown = new("\U0001F451");

        /// <summary>
        /// 👒 - WOMANS HAT womans hat
        /// </summary>
        public static readonly Emoji WomansHatWomansHat = new("\U0001F452");

        /// <summary>
        /// 🎩 - TOP HAT
        /// </summary>
        public static readonly Emoji TopHat = new("\U0001F3A9");

        /// <summary>
        /// 🎓 - GRADUATION CAP
        /// </summary>
        public static readonly Emoji GraduationCap = new("\U0001F393");

        /// <summary>
        /// ⛑ - HELMET WITH WHITE CROSS
        /// </summary>
        public static readonly Emoji HelmetWithWhiteCross = new("\U000026D1");

        /// <summary>
        /// 📿 - PRAYER BEADS
        /// </summary>
        public static readonly Emoji PrayerBeads = new("\U0001F4FF");

        /// <summary>
        /// 💄 - LIPSTICK
        /// </summary>
        public static readonly Emoji Lipstick = new("\U0001F484");

        /// <summary>
        /// 💍 - RING
        /// </summary>
        public static readonly Emoji Ring = new("\U0001F48D");

        /// <summary>
        /// 💎 - GEM STONE
        /// </summary>
        public static readonly Emoji GemStone = new("\U0001F48E");
    }

    /// <summary>
    /// Animals & Nature
    /// </summary>
    public static class AnimalsAndNature
    {
        /// <summary>
        /// 🐵 - MONKEY FACE
        /// </summary>
        public static readonly Emoji MonkeyFace = new("\U0001F435");

        /// <summary>
        /// 🐒 - MONKEY
        /// </summary>
        public static readonly Emoji Monkey = new("\U0001F412");

        /// <summary>
        /// 🦍 - GORILLA
        /// </summary>
        public static readonly Emoji Gorilla = new("\U0001F98D");

        /// <summary>
        /// 🐶 - DOG FACE
        /// </summary>
        public static readonly Emoji DogFace = new("\U0001F436");

        /// <summary>
        /// 🐕 - DOG
        /// </summary>
        public static readonly Emoji Dog = new("\U0001F415");

        /// <summary>
        /// 🐩 - POODLE
        /// </summary>
        public static readonly Emoji Poodle = new("\U0001F429");

        /// <summary>
        /// 🐺 - WOLF FACE
        /// </summary>
        public static readonly Emoji WolfFace = new("\U0001F43A");

        /// <summary>
        /// 🦊 - FOX FACE
        /// </summary>
        public static readonly Emoji FoxFace = new("\U0001F98A");

        /// <summary>
        /// 🐱 - CAT FACE
        /// </summary>
        public static readonly Emoji CatFace = new("\U0001F431");

        /// <summary>
        /// 🐈 - CAT
        /// </summary>
        public static readonly Emoji Cat = new("\U0001F408");

        /// <summary>
        /// 🦁 - LION FACE
        /// </summary>
        public static readonly Emoji LionFace = new("\U0001F981");

        /// <summary>
        /// 🐯 - TIGER FACE
        /// </summary>
        public static readonly Emoji TigerFace = new("\U0001F42F");

        /// <summary>
        /// 🐅 - TIGER
        /// </summary>
        public static readonly Emoji Tiger = new("\U0001F405");

        /// <summary>
        /// 🐆 - LEOPARD
        /// </summary>
        public static readonly Emoji Leopard = new("\U0001F406");

        /// <summary>
        /// 🐴 - HORSE FACE
        /// </summary>
        public static readonly Emoji HorseFace = new("\U0001F434");

        /// <summary>
        /// 🐎 - HORSE
        /// </summary>
        public static readonly Emoji Horse = new("\U0001F40E");

        /// <summary>
        /// 🦌 - DEER
        /// </summary>
        public static readonly Emoji Deer = new("\U0001F98C");

        /// <summary>
        /// 🦄 - UNICORN FACE
        /// </summary>
        public static readonly Emoji UnicornFace = new("\U0001F984");

        /// <summary>
        /// 🐮 - COW FACE
        /// </summary>
        public static readonly Emoji CowFace = new("\U0001F42E");

        /// <summary>
        /// 🐂 - OX
        /// </summary>
        public static readonly Emoji Ox = new("\U0001F402");

        /// <summary>
        /// 🐃 - WATER BUFFALO
        /// </summary>
        public static readonly Emoji WaterBuffalo = new("\U0001F403");

        /// <summary>
        /// 🐄 - COW
        /// </summary>
        public static readonly Emoji Cow = new("\U0001F404");

        /// <summary>
        /// 🐷 - PIG FACE
        /// </summary>
        public static readonly Emoji PigFace = new("\U0001F437");

        /// <summary>
        /// 🐖 - PIG
        /// </summary>
        public static readonly Emoji Pig = new("\U0001F416");

        /// <summary>
        /// 🐗 - BOAR
        /// </summary>
        public static readonly Emoji Boar = new("\U0001F417");

        /// <summary>
        /// 🐽 - PIG NOSE
        /// </summary>
        public static readonly Emoji PigNose = new("\U0001F43D");

        /// <summary>
        /// 🐏 - RAM
        /// </summary>
        public static readonly Emoji Ram = new("\U0001F40F");

        /// <summary>
        /// 🐑 - SHEEP
        /// </summary>
        public static readonly Emoji Sheep = new("\U0001F411");

        /// <summary>
        /// 🐐 - GOAT
        /// </summary>
        public static readonly Emoji Goat = new("\U0001F410");

        /// <summary>
        /// 🐪 - DROMEDARY CAMEL camel
        /// </summary>
        public static readonly Emoji DromedaryCamelCamel = new("\U0001F42A");

        /// <summary>
        /// 🐫 - BACTRIAN CAMEL two-hump camel
        /// </summary>
        public static readonly Emoji BactrianCamelTwoHumpCamel = new("\U0001F42B");

        /// <summary>
        /// 🐘 - ELEPHANT
        /// </summary>
        public static readonly Emoji Elephant = new("\U0001F418");

        /// <summary>
        /// 🦏 - RHINOCEROS
        /// </summary>
        public static readonly Emoji Rhinoceros = new("\U0001F98F");

        /// <summary>
        /// 🐭 - MOUSE FACE
        /// </summary>
        public static readonly Emoji MouseFace = new("\U0001F42D");

        /// <summary>
        /// 🐁 - MOUSE
        /// </summary>
        public static readonly Emoji Mouse = new("\U0001F401");

        /// <summary>
        /// 🐀 - RAT
        /// </summary>
        public static readonly Emoji Rat = new("\U0001F400");

        /// <summary>
        /// 🐹 - HAMSTER FACE
        /// </summary>
        public static readonly Emoji HamsterFace = new("\U0001F439");

        /// <summary>
        /// 🐰 - RABBIT FACE
        /// </summary>
        public static readonly Emoji RabbitFace = new("\U0001F430");

        /// <summary>
        /// 🐇 - RABBIT
        /// </summary>
        public static readonly Emoji Rabbit = new("\U0001F407");

        /// <summary>
        /// 🐿 - CHIPMUNK
        /// </summary>
        public static readonly Emoji Chipmunk = new("\U0001F43F");

        /// <summary>
        /// 🦇 - BAT
        /// </summary>
        public static readonly Emoji Bat = new("\U0001F987");

        /// <summary>
        /// 🐻 - BEAR FACE
        /// </summary>
        public static readonly Emoji BearFace = new("\U0001F43B");

        /// <summary>
        /// 🐨 - KOALA
        /// </summary>
        public static readonly Emoji Koala = new("\U0001F428");

        /// <summary>
        /// 🐼 - PANDA FACE
        /// </summary>
        public static readonly Emoji PandaFace = new("\U0001F43C");

        /// <summary>
        /// 🐾 - PAW PRINTS
        /// </summary>
        public static readonly Emoji PawPrints = new("\U0001F43E");

        /// <summary>
        /// 🦃 - TURKEY
        /// </summary>
        public static readonly Emoji Turkey = new("\U0001F983");

        /// <summary>
        /// 🐔 - CHICKEN
        /// </summary>
        public static readonly Emoji Chicken = new("\U0001F414");

        /// <summary>
        /// 🐓 - ROOSTER
        /// </summary>
        public static readonly Emoji Rooster = new("\U0001F413");

        /// <summary>
        /// 🐣 - HATCHING CHICK
        /// </summary>
        public static readonly Emoji HatchingChick = new("\U0001F423");

        /// <summary>
        /// 🐤 - BABY CHICK
        /// </summary>
        public static readonly Emoji BabyChick = new("\U0001F424");

        /// <summary>
        /// 🐥 - FRONT-FACING BABY CHICK
        /// </summary>
        public static readonly Emoji FrontFacingBabyChick = new("\U0001F425");

        /// <summary>
        /// 🐦 - BIRD
        /// </summary>
        public static readonly Emoji Bird = new("\U0001F426");

        /// <summary>
        /// 🐧 - PENGUIN
        /// </summary>
        public static readonly Emoji Penguin = new("\U0001F427");

        /// <summary>
        /// 🕊 - DOVE OF PEACE dove
        /// </summary>
        public static readonly Emoji DoveOfPeaceDove = new("\U0001F54A");

        /// <summary>
        /// 🦅 - EAGLE
        /// </summary>
        public static readonly Emoji Eagle = new("\U0001F985");

        /// <summary>
        /// 🦆 - DUCK
        /// </summary>
        public static readonly Emoji Duck = new("\U0001F986");

        /// <summary>
        /// 🦉 - OWL
        /// </summary>
        public static readonly Emoji Owl = new("\U0001F989");

        /// <summary>
        /// 🐸 - FROG FACE
        /// </summary>
        public static readonly Emoji FrogFace = new("\U0001F438");

        /// <summary>
        /// 🐊 - CROCODILE
        /// </summary>
        public static readonly Emoji Crocodile = new("\U0001F40A");

        /// <summary>
        /// 🐢 - TURTLE
        /// </summary>
        public static readonly Emoji Turtle = new("\U0001F422");

        /// <summary>
        /// 🦎 - LIZARD
        /// </summary>
        public static readonly Emoji Lizard = new("\U0001F98E");

        /// <summary>
        /// 🐍 - SNAKE
        /// </summary>
        public static readonly Emoji Snake = new("\U0001F40D");

        /// <summary>
        /// 🐲 - DRAGON FACE
        /// </summary>
        public static readonly Emoji DragonFace = new("\U0001F432");

        /// <summary>
        /// 🐉 - DRAGON
        /// </summary>
        public static readonly Emoji Dragon = new("\U0001F409");

        /// <summary>
        /// 🐳 - SPOUTING WHALE
        /// </summary>
        public static readonly Emoji SpoutingWhale = new("\U0001F433");

        /// <summary>
        /// 🐋 - WHALE
        /// </summary>
        public static readonly Emoji Whale = new("\U0001F40B");

        /// <summary>
        /// 🐬 - DOLPHIN
        /// </summary>
        public static readonly Emoji Dolphin = new("\U0001F42C");

        /// <summary>
        /// 🐟 - FISH
        /// </summary>
        public static readonly Emoji Fish = new("\U0001F41F");

        /// <summary>
        /// 🐠 - TROPICAL FISH
        /// </summary>
        public static readonly Emoji TropicalFish = new("\U0001F420");

        /// <summary>
        /// 🐡 - BLOWFISH
        /// </summary>
        public static readonly Emoji Blowfish = new("\U0001F421");

        /// <summary>
        /// 🦈 - SHARK
        /// </summary>
        public static readonly Emoji Shark = new("\U0001F988");

        /// <summary>
        /// 🐙 - OCTOPUS
        /// </summary>
        public static readonly Emoji Octopus = new("\U0001F419");

        /// <summary>
        /// 🐚 - SPIRAL SHELL
        /// </summary>
        public static readonly Emoji SpiralShell = new("\U0001F41A");

        /// <summary>
        /// 🦀 - CRAB
        /// </summary>
        public static readonly Emoji Crab = new("\U0001F980");

        /// <summary>
        /// 🦐 - SHRIMP
        /// </summary>
        public static readonly Emoji Shrimp = new("\U0001F990");

        /// <summary>
        /// 🦑 - SQUID
        /// </summary>
        public static readonly Emoji Squid = new("\U0001F991");

        /// <summary>
        /// 🦋 - BUTTERFLY
        /// </summary>
        public static readonly Emoji Butterfly = new("\U0001F98B");

        /// <summary>
        /// 🐌 - SNAIL
        /// </summary>
        public static readonly Emoji Snail = new("\U0001F40C");

        /// <summary>
        /// 🐛 - BUG
        /// </summary>
        public static readonly Emoji Bug = new("\U0001F41B");

        /// <summary>
        /// 🐜 - ANT
        /// </summary>
        public static readonly Emoji Ant = new("\U0001F41C");

        /// <summary>
        /// 🐝 - HONEYBEE
        /// </summary>
        public static readonly Emoji Honeybee = new("\U0001F41D");

        /// <summary>
        /// 🐞 - LADY BEETLE
        /// </summary>
        public static readonly Emoji LadyBeetle = new("\U0001F41E");

        /// <summary>
        /// 🕷 - SPIDER
        /// </summary>
        public static readonly Emoji Spider = new("\U0001F577");

        /// <summary>
        /// 🕸 - SPIDER WEB
        /// </summary>
        public static readonly Emoji SpiderWeb = new("\U0001F578");

        /// <summary>
        /// 🦂 - SCORPION
        /// </summary>
        public static readonly Emoji Scorpion = new("\U0001F982");

        /// <summary>
        /// 💐 - BOUQUET
        /// </summary>
        public static readonly Emoji Bouquet = new("\U0001F490");

        /// <summary>
        /// 🌸 - CHERRY BLOSSOM
        /// </summary>
        public static readonly Emoji CherryBlossom = new("\U0001F338");

        /// <summary>
        /// 💮 - WHITE FLOWER
        /// </summary>
        public static readonly Emoji WhiteFlower = new("\U0001F4AE");

        /// <summary>
        /// 🏵 - ROSETTE
        /// </summary>
        public static readonly Emoji Rosette = new("\U0001F3F5");

        /// <summary>
        /// 🌹 - ROSE
        /// </summary>
        public static readonly Emoji Rose = new("\U0001F339");

        /// <summary>
        /// 🥀 - WILTED FLOWER
        /// </summary>
        public static readonly Emoji WiltedFlower = new("\U0001F940");

        /// <summary>
        /// 🌺 - HIBISCUS
        /// </summary>
        public static readonly Emoji Hibiscus = new("\U0001F33A");

        /// <summary>
        /// 🌻 - SUNFLOWER
        /// </summary>
        public static readonly Emoji Sunflower = new("\U0001F33B");

        /// <summary>
        /// 🌼 - BLOSSOM
        /// </summary>
        public static readonly Emoji Blossom = new("\U0001F33C");

        /// <summary>
        /// 🌷 - TULIP
        /// </summary>
        public static readonly Emoji Tulip = new("\U0001F337");

        /// <summary>
        /// 🌱 - SEEDLING
        /// </summary>
        public static readonly Emoji Seedling = new("\U0001F331");

        /// <summary>
        /// 🌲 - EVERGREEN TREE evergreen
        /// </summary>
        public static readonly Emoji EvergreenTreeEvergreen = new("\U0001F332");

        /// <summary>
        /// 🌳 - DECIDUOUS TREE
        /// </summary>
        public static readonly Emoji DeciduousTree = new("\U0001F333");

        /// <summary>
        /// 🌴 - PALM TREE
        /// </summary>
        public static readonly Emoji PalmTree = new("\U0001F334");

        /// <summary>
        /// 🌵 - CACTUS
        /// </summary>
        public static readonly Emoji Cactus = new("\U0001F335");

        /// <summary>
        /// 🌾 - EAR OF RICE sheaf of rice
        /// </summary>
        public static readonly Emoji EarOfRiceSheafOfRice = new("\U0001F33E");

        /// <summary>
        /// 🌿 - HERB
        /// </summary>
        public static readonly Emoji Herb = new("\U0001F33F");

        /// <summary>
        /// ☘ - SHAMROCK
        /// </summary>
        public static readonly Emoji Shamrock = new("\U00002618");

        /// <summary>
        /// 🍀 - FOUR LEAF CLOVER
        /// </summary>
        public static readonly Emoji FourLeafClover = new("\U0001F340");

        /// <summary>
        /// 🍁 - MAPLE LEAF
        /// </summary>
        public static readonly Emoji MapleLeaf = new("\U0001F341");

        /// <summary>
        /// 🍂 - FALLEN LEAF
        /// </summary>
        public static readonly Emoji FallenLeaf = new("\U0001F342");

        /// <summary>
        /// 🍃 - LEAF FLUTTERING IN WIND
        /// </summary>
        public static readonly Emoji LeafFlutteringInWind = new("\U0001F343");

        /// <summary>
        /// 🍇 - GRAPES
        /// </summary>
        public static readonly Emoji Grapes = new("\U0001F347");

        /// <summary>
        /// 🍈 - MELON
        /// </summary>
        public static readonly Emoji Melon = new("\U0001F348");

        /// <summary>
        /// 🍉 - WATERMELON
        /// </summary>
        public static readonly Emoji Watermelon = new("\U0001F349");

        /// <summary>
        /// 🍊 - TANGERINE
        /// </summary>
        public static readonly Emoji Tangerine = new("\U0001F34A");

        /// <summary>
        /// 🍋 - LEMON
        /// </summary>
        public static readonly Emoji Lemon = new("\U0001F34B");

        /// <summary>
        /// 🍌 - BANANA
        /// </summary>
        public static readonly Emoji Banana = new("\U0001F34C");

        /// <summary>
        /// 🍍 - PINEAPPLE
        /// </summary>
        public static readonly Emoji Pineapple = new("\U0001F34D");

        /// <summary>
        /// 🍎 - RED APPLE
        /// </summary>
        public static readonly Emoji RedApple = new("\U0001F34E");

        /// <summary>
        /// 🍏 - GREEN APPLE
        /// </summary>
        public static readonly Emoji GreenApple = new("\U0001F34F");

        /// <summary>
        /// 🍐 - PEAR
        /// </summary>
        public static readonly Emoji Pear = new("\U0001F350");

        /// <summary>
        /// 🍑 - PEACH
        /// </summary>
        public static readonly Emoji Peach = new("\U0001F351");

        /// <summary>
        /// 🍒 - CHERRIES
        /// </summary>
        public static readonly Emoji Cherries = new("\U0001F352");

        /// <summary>
        /// 🍓 - STRAWBERRY
        /// </summary>
        public static readonly Emoji Strawberry = new("\U0001F353");

        /// <summary>
        /// 🍅 - TOMATO
        /// </summary>
        public static readonly Emoji Tomato = new("\U0001F345");

        /// <summary>
        /// 🥝 - KIWIFRUIT
        /// </summary>
        public static readonly Emoji Kiwifruit = new("\U0001F95D");

        /// <summary>
        /// 🥑 - AVOCADO
        /// </summary>
        public static readonly Emoji Avocado = new("\U0001F951");

        /// <summary>
        /// 🍆 - AUBERGINE eggplant
        /// </summary>
        public static readonly Emoji AubergineEggplant = new("\U0001F346");

        /// <summary>
        /// 🥔 - POTATO
        /// </summary>
        public static readonly Emoji Potato = new("\U0001F954");

        /// <summary>
        /// 🥕 - CARROT
        /// </summary>
        public static readonly Emoji Carrot = new("\U0001F955");

        /// <summary>
        /// 🌽 - EAR OF MAIZE ear of corn
        /// </summary>
        public static readonly Emoji EarOfMaizeEarOfCorn = new("\U0001F33D");

        /// <summary>
        /// 🌶 - HOT PEPPER
        /// </summary>
        public static readonly Emoji HotPepper = new("\U0001F336");

        /// <summary>
        /// 🥒 - CUCUMBER
        /// </summary>
        public static readonly Emoji Cucumber = new("\U0001F952");

        /// <summary>
        /// 🍄 - MUSHROOM
        /// </summary>
        public static readonly Emoji Mushroom = new("\U0001F344");

        /// <summary>
        /// 🥜 - PEANUTS
        /// </summary>
        public static readonly Emoji Peanuts = new("\U0001F95C");

        /// <summary>
        /// 🌰 - CHESTNUT
        /// </summary>
        public static readonly Emoji Chestnut = new("\U0001F330");

        /// <summary>
        /// 🍞 - BREAD
        /// </summary>
        public static readonly Emoji Bread = new("\U0001F35E");

        /// <summary>
        /// 🥐 - CROISSANT
        /// </summary>
        public static readonly Emoji Croissant = new("\U0001F950");

        /// <summary>
        /// 🥖 - BAGUETTE BREAD
        /// </summary>
        public static readonly Emoji BaguetteBread = new("\U0001F956");

        /// <summary>
        /// 🥞 - PANCAKES
        /// </summary>
        public static readonly Emoji Pancakes = new("\U0001F95E");

        /// <summary>
        /// 🧀 - CHEESE WEDGE
        /// </summary>
        public static readonly Emoji CheeseWedge = new("\U0001F9C0");

        /// <summary>
        /// 🍖 - MEAT ON BONE
        /// </summary>
        public static readonly Emoji MeatOnBone = new("\U0001F356");

        /// <summary>
        /// 🍗 - POULTRY LEG
        /// </summary>
        public static readonly Emoji PoultryLeg = new("\U0001F357");

        /// <summary>
        /// 🥓 - BACON
        /// </summary>
        public static readonly Emoji Bacon = new("\U0001F953");

        /// <summary>
        /// 🍔 - HAMBURGER
        /// </summary>
        public static readonly Emoji Hamburger = new("\U0001F354");

        /// <summary>
        /// 🍟 - FRENCH FRIES
        /// </summary>
        public static readonly Emoji FrenchFries = new("\U0001F35F");

        /// <summary>
        /// 🍕 - SLICE OF PIZZA pizza
        /// </summary>
        public static readonly Emoji SliceOfPizzaPizza = new("\U0001F355");

        /// <summary>
        /// 🌭 - HOT DOG
        /// </summary>
        public static readonly Emoji HotDog = new("\U0001F32D");

        /// <summary>
        /// 🌮 - TACO
        /// </summary>
        public static readonly Emoji Taco = new("\U0001F32E");

        /// <summary>
        /// 🌯 - BURRITO
        /// </summary>
        public static readonly Emoji Burrito = new("\U0001F32F");

        /// <summary>
        /// 🥙 - STUFFED FLATBREAD
        /// </summary>
        public static readonly Emoji StuffedFlatbread = new("\U0001F959");

        /// <summary>
        /// 🥚 - EGG
        /// </summary>
        public static readonly Emoji Egg = new("\U0001F95A");

        /// <summary>
        /// 🍳 - COOKING
        /// </summary>
        public static readonly Emoji Cooking = new("\U0001F373");

        /// <summary>
        /// 🥘 - SHALLOW PAN OF FOOD
        /// </summary>
        public static readonly Emoji ShallowPanOfFood = new("\U0001F958");

        /// <summary>
        /// 🍲 - POT OF FOOD
        /// </summary>
        public static readonly Emoji PotOfFood = new("\U0001F372");

        /// <summary>
        /// 🥗 - GREEN SALAD
        /// </summary>
        public static readonly Emoji GreenSalad = new("\U0001F957");

        /// <summary>
        /// 🍿 - POPCORN
        /// </summary>
        public static readonly Emoji Popcorn = new("\U0001F37F");

        /// <summary>
        /// 🍱 - BENTO BOX
        /// </summary>
        public static readonly Emoji BentoBox = new("\U0001F371");

        /// <summary>
        /// 🍘 - RICE CRACKER
        /// </summary>
        public static readonly Emoji RiceCracker = new("\U0001F358");

        /// <summary>
        /// 🍙 - RICE BALL
        /// </summary>
        public static readonly Emoji RiceBall = new("\U0001F359");

        /// <summary>
        /// 🍚 - COOKED RICE
        /// </summary>
        public static readonly Emoji CookedRice = new("\U0001F35A");

        /// <summary>
        /// 🍛 - CURRY AND RICE curry rice
        /// </summary>
        public static readonly Emoji CurryAndRiceCurryRice = new("\U0001F35B");

        /// <summary>
        /// 🍜 - STEAMING BOWL
        /// </summary>
        public static readonly Emoji SteamingBowl = new("\U0001F35C");

        /// <summary>
        /// 🍝 - SPAGHETTI
        /// </summary>
        public static readonly Emoji Spaghetti = new("\U0001F35D");

        /// <summary>
        /// 🍠 - ROASTED SWEET POTATO
        /// </summary>
        public static readonly Emoji RoastedSweetPotato = new("\U0001F360");

        /// <summary>
        /// 🍢 - ODEN
        /// </summary>
        public static readonly Emoji Oden = new("\U0001F362");

        /// <summary>
        /// 🍣 - SUSHI
        /// </summary>
        public static readonly Emoji Sushi = new("\U0001F363");

        /// <summary>
        /// 🍤 - FRIED SHRIMP
        /// </summary>
        public static readonly Emoji FriedShrimp = new("\U0001F364");

        /// <summary>
        /// 🍥 - FISH CAKE WITH SWIRL DESIGN fish cake with swirl
        /// </summary>
        public static readonly Emoji FishCakeWithSwirlDesignFishCakeWithSwirl = new("\U0001F365");

        /// <summary>
        /// 🍡 - DANGO
        /// </summary>
        public static readonly Emoji Dango = new("\U0001F361");

        /// <summary>
        /// 🍦 - SOFT ICE CREAM
        /// </summary>
        public static readonly Emoji SoftIceCream = new("\U0001F366");

        /// <summary>
        /// 🍧 - SHAVED ICE
        /// </summary>
        public static readonly Emoji ShavedIce = new("\U0001F367");

        /// <summary>
        /// 🍨 - ICE CREAM
        /// </summary>
        public static readonly Emoji IceCream = new("\U0001F368");

        /// <summary>
        /// 🍩 - DOUGHNUT
        /// </summary>
        public static readonly Emoji Doughnut = new("\U0001F369");

        /// <summary>
        /// 🍪 - COOKIE
        /// </summary>
        public static readonly Emoji Cookie = new("\U0001F36A");

        /// <summary>
        /// 🎂 - BIRTHDAY CAKE
        /// </summary>
        public static readonly Emoji BirthdayCake = new("\U0001F382");

        /// <summary>
        /// 🍰 - SHORTCAKE
        /// </summary>
        public static readonly Emoji Shortcake = new("\U0001F370");

        /// <summary>
        /// 🍫 - CHOCOLATE BAR
        /// </summary>
        public static readonly Emoji ChocolateBar = new("\U0001F36B");

        /// <summary>
        /// 🍬 - CANDY
        /// </summary>
        public static readonly Emoji Candy = new("\U0001F36C");

        /// <summary>
        /// 🍭 - LOLLIPOP
        /// </summary>
        public static readonly Emoji Lollipop = new("\U0001F36D");

        /// <summary>
        /// 🍮 - CUSTARD
        /// </summary>
        public static readonly Emoji Custard = new("\U0001F36E");

        /// <summary>
        /// 🍯 - HONEY POT
        /// </summary>
        public static readonly Emoji HoneyPot = new("\U0001F36F");

        /// <summary>
        /// 🍼 - BABY BOTTLE
        /// </summary>
        public static readonly Emoji BabyBottle = new("\U0001F37C");

        /// <summary>
        /// 🥛 - GLASS OF MILK
        /// </summary>
        public static readonly Emoji GlassOfMilk = new("\U0001F95B");

        /// <summary>
        /// ☕ - HOT BEVERAGE
        /// </summary>
        public static readonly Emoji HotBeverage = new("\U00002615");

        /// <summary>
        /// 🍵 - TEACUP WITHOUT HANDLE
        /// </summary>
        public static readonly Emoji TeacupWithoutHandle = new("\U0001F375");

        /// <summary>
        /// 🍶 - SAKE BOTTLE AND CUP sake
        /// </summary>
        public static readonly Emoji SakeBottleAndCupSake = new("\U0001F376");

        /// <summary>
        /// 🍾 - BOTTLE WITH POPPING CORK
        /// </summary>
        public static readonly Emoji BottleWithPoppingCork = new("\U0001F37E");

        /// <summary>
        /// 🍷 - WINE GLASS
        /// </summary>
        public static readonly Emoji WineGlass = new("\U0001F377");

        /// <summary>
        /// 🍸 - COCKTAIL GLASS
        /// </summary>
        public static readonly Emoji CocktailGlass = new("\U0001F378");

        /// <summary>
        /// 🍹 - TROPICAL DRINK
        /// </summary>
        public static readonly Emoji TropicalDrink = new("\U0001F379");

        /// <summary>
        /// 🍺 - BEER MUG
        /// </summary>
        public static readonly Emoji BeerMug = new("\U0001F37A");

        /// <summary>
        /// 🍻 - CLINKING BEER MUGS
        /// </summary>
        public static readonly Emoji ClinkingBeerMugs = new("\U0001F37B");

        /// <summary>
        /// 🥂 - CLINKING GLASSES
        /// </summary>
        public static readonly Emoji ClinkingGlasses = new("\U0001F942");

        /// <summary>
        /// 🥃 - TUMBLER GLASS
        /// </summary>
        public static readonly Emoji TumblerGlass = new("\U0001F943");

        /// <summary>
        /// 🍽 - FORK AND KNIFE WITH PLATE
        /// </summary>
        public static readonly Emoji ForkAndKnifeWithPlate = new("\U0001F37D");

        /// <summary>
        /// 🍴 - FORK AND KNIFE
        /// </summary>
        public static readonly Emoji ForkAndKnife = new("\U0001F374");

        /// <summary>
        /// 🥄 - SPOON
        /// </summary>
        public static readonly Emoji Spoon = new("\U0001F944");

        /// <summary>
        /// 🔪 - HOCHO kitchen knife
        /// </summary>
        public static readonly Emoji HochoKitchenKnife = new("\U0001F52A");

        /// <summary>
        /// 🏺 - AMPHORA
        /// </summary>
        public static readonly Emoji Amphora = new("\U0001F3FA");
    }

    /// <summary>
    /// Travel & Places
    /// </summary>
    public static class TravelAndPlaces
    {
        /// <summary>
        /// 🌍 - EARTH GLOBE EUROPE-AFRICA globe showing europe-africa
        /// </summary>
        public static readonly Emoji EarthGlobeEuropeAfricaGlobeShowingEuropeAfrica = new("\U0001F30D");

        /// <summary>
        /// 🌎 - EARTH GLOBE AMERICAS globe showing americas
        /// </summary>
        public static readonly Emoji EarthGlobeAmericasGlobeShowingAmericas = new("\U0001F30E");

        /// <summary>
        /// 🌏 - EARTH GLOBE ASIA-AUSTRALIA globe showing asia-australia
        /// </summary>
        public static readonly Emoji EarthGlobeAsiaAustraliaGlobeShowingAsiaAustralia = new("\U0001F30F");

        /// <summary>
        /// 🌐 - GLOBE WITH MERIDIANS
        /// </summary>
        public static readonly Emoji GlobeWithMeridians = new("\U0001F310");

        /// <summary>
        /// 🗺 - WORLD MAP
        /// </summary>
        public static readonly Emoji WorldMap = new("\U0001F5FA");

        /// <summary>
        /// 🗾 - SILHOUETTE OF JAPAN map of japan
        /// </summary>
        public static readonly Emoji SilhouetteOfJapanMapOfJapan = new("\U0001F5FE");

        /// <summary>
        /// 🏔 - SNOW CAPPED MOUNTAIN snow-capped mountain
        /// </summary>
        public static readonly Emoji SnowCappedMountainSnowCappedMountain = new("\U0001F3D4");

        /// <summary>
        /// ⛰ - MOUNTAIN
        /// </summary>
        public static readonly Emoji Mountain = new("\U000026F0");

        /// <summary>
        /// 🌋 - VOLCANO
        /// </summary>
        public static readonly Emoji Volcano = new("\U0001F30B");

        /// <summary>
        /// 🗻 - MOUNT FUJI
        /// </summary>
        public static readonly Emoji MountFuji = new("\U0001F5FB");

        /// <summary>
        /// 🏕 - CAMPING
        /// </summary>
        public static readonly Emoji Camping = new("\U0001F3D5");

        /// <summary>
        /// 🏖 - BEACH WITH UMBRELLA
        /// </summary>
        public static readonly Emoji BeachWithUmbrella = new("\U0001F3D6");

        /// <summary>
        /// 🏜 - DESERT
        /// </summary>
        public static readonly Emoji Desert = new("\U0001F3DC");

        /// <summary>
        /// 🏝 - DESERT ISLAND
        /// </summary>
        public static readonly Emoji DesertIsland = new("\U0001F3DD");

        /// <summary>
        /// 🏞 - NATIONAL PARK
        /// </summary>
        public static readonly Emoji NationalPark = new("\U0001F3DE");

        /// <summary>
        /// 🏟 - STADIUM
        /// </summary>
        public static readonly Emoji Stadium = new("\U0001F3DF");

        /// <summary>
        /// 🏛 - CLASSICAL BUILDING
        /// </summary>
        public static readonly Emoji ClassicalBuilding = new("\U0001F3DB");

        /// <summary>
        /// 🏗 - BUILDING CONSTRUCTION
        /// </summary>
        public static readonly Emoji BuildingConstruction = new("\U0001F3D7");

        /// <summary>
        /// 🏘 - HOUSE BUILDINGS
        /// </summary>
        public static readonly Emoji HouseBuildings = new("\U0001F3D8");

        /// <summary>
        /// 🏙 - CITYSCAPE
        /// </summary>
        public static readonly Emoji Cityscape = new("\U0001F3D9");

        /// <summary>
        /// 🏚 - DERELICT HOUSE BUILDING
        /// </summary>
        public static readonly Emoji DerelictHouseBuilding = new("\U0001F3DA");

        /// <summary>
        /// 🏠 - HOUSE BUILDING
        /// </summary>
        public static readonly Emoji HouseBuilding = new("\U0001F3E0");

        /// <summary>
        /// 🏡 - HOUSE WITH GARDEN
        /// </summary>
        public static readonly Emoji HouseWithGarden = new("\U0001F3E1");

        /// <summary>
        /// 🏢 - OFFICE BUILDING
        /// </summary>
        public static readonly Emoji OfficeBuilding = new("\U0001F3E2");

        /// <summary>
        /// 🏣 - JAPANESE POST OFFICE
        /// </summary>
        public static readonly Emoji JapanesePostOffice = new("\U0001F3E3");

        /// <summary>
        /// 🏤 - EUROPEAN POST OFFICE post office
        /// </summary>
        public static readonly Emoji EuropeanPostOfficePostOffice = new("\U0001F3E4");

        /// <summary>
        /// 🏥 - HOSPITAL
        /// </summary>
        public static readonly Emoji Hospital = new("\U0001F3E5");

        /// <summary>
        /// 🏦 - BANK
        /// </summary>
        public static readonly Emoji Bank = new("\U0001F3E6");

        /// <summary>
        /// 🏨 - HOTEL
        /// </summary>
        public static readonly Emoji Hotel = new("\U0001F3E8");

        /// <summary>
        /// 🏩 - LOVE HOTEL
        /// </summary>
        public static readonly Emoji LoveHotel = new("\U0001F3E9");

        /// <summary>
        /// 🏪 - CONVENIENCE STORE
        /// </summary>
        public static readonly Emoji ConvenienceStore = new("\U0001F3EA");

        /// <summary>
        /// 🏫 - SCHOOL
        /// </summary>
        public static readonly Emoji School = new("\U0001F3EB");

        /// <summary>
        /// 🏬 - DEPARTMENT STORE
        /// </summary>
        public static readonly Emoji DepartmentStore = new("\U0001F3EC");

        /// <summary>
        /// 🏭 - FACTORY
        /// </summary>
        public static readonly Emoji Factory = new("\U0001F3ED");

        /// <summary>
        /// 🏯 - JAPANESE CASTLE
        /// </summary>
        public static readonly Emoji JapaneseCastle = new("\U0001F3EF");

        /// <summary>
        /// 🏰 - EUROPEAN CASTLE castle
        /// </summary>
        public static readonly Emoji EuropeanCastleCastle = new("\U0001F3F0");

        /// <summary>
        /// 💒 - WEDDING
        /// </summary>
        public static readonly Emoji Wedding = new("\U0001F492");

        /// <summary>
        /// 🗼 - TOKYO TOWER
        /// </summary>
        public static readonly Emoji TokyoTower = new("\U0001F5FC");

        /// <summary>
        /// 🗽 - STATUE OF LIBERTY
        /// </summary>
        public static readonly Emoji StatueOfLiberty = new("\U0001F5FD");

        /// <summary>
        /// ⛪ - CHURCH
        /// </summary>
        public static readonly Emoji Church = new("\U000026EA");

        /// <summary>
        /// 🕌 - MOSQUE
        /// </summary>
        public static readonly Emoji Mosque = new("\U0001F54C");

        /// <summary>
        /// 🕍 - SYNAGOGUE
        /// </summary>
        public static readonly Emoji Synagogue = new("\U0001F54D");

        /// <summary>
        /// ⛩ - SHINTO SHRINE
        /// </summary>
        public static readonly Emoji ShintoShrine = new("\U000026E9");

        /// <summary>
        /// 🕋 - KAABA
        /// </summary>
        public static readonly Emoji Kaaba = new("\U0001F54B");

        /// <summary>
        /// ⛲ - FOUNTAIN
        /// </summary>
        public static readonly Emoji Fountain = new("\U000026F2");

        /// <summary>
        /// ⛺ - TENT
        /// </summary>
        public static readonly Emoji Tent = new("\U000026FA");

        /// <summary>
        /// 🌁 - FOGGY
        /// </summary>
        public static readonly Emoji Foggy = new("\U0001F301");

        /// <summary>
        /// 🌃 - NIGHT WITH STARS
        /// </summary>
        public static readonly Emoji NightWithStars = new("\U0001F303");

        /// <summary>
        /// 🌄 - SUNRISE OVER MOUNTAINS
        /// </summary>
        public static readonly Emoji SunriseOverMountains = new("\U0001F304");

        /// <summary>
        /// 🌅 - SUNRISE
        /// </summary>
        public static readonly Emoji Sunrise = new("\U0001F305");

        /// <summary>
        /// 🌆 - CITYSCAPE AT DUSK
        /// </summary>
        public static readonly Emoji CityscapeAtDusk = new("\U0001F306");

        /// <summary>
        /// 🌇 - SUNSET OVER BUILDINGS sunset
        /// </summary>
        public static readonly Emoji SunsetOverBuildingsSunset = new("\U0001F307");

        /// <summary>
        /// 🌉 - BRIDGE AT NIGHT
        /// </summary>
        public static readonly Emoji BridgeAtNight = new("\U0001F309");

        /// <summary>
        /// ♨ - HOT SPRINGS
        /// </summary>
        public static readonly Emoji HotSprings = new("\U00002668");

        /// <summary>
        /// 🌌 - MILKY WAY
        /// </summary>
        public static readonly Emoji MilkyWay = new("\U0001F30C");

        /// <summary>
        /// 🎠 - CAROUSEL HORSE
        /// </summary>
        public static readonly Emoji CarouselHorse = new("\U0001F3A0");

        /// <summary>
        /// 🎡 - FERRIS WHEEL
        /// </summary>
        public static readonly Emoji FerrisWheel = new("\U0001F3A1");

        /// <summary>
        /// 🎢 - ROLLER COASTER
        /// </summary>
        public static readonly Emoji RollerCoaster = new("\U0001F3A2");

        /// <summary>
        /// 💈 - BARBER POLE
        /// </summary>
        public static readonly Emoji BarberPole = new("\U0001F488");

        /// <summary>
        /// 🎪 - CIRCUS TENT
        /// </summary>
        public static readonly Emoji CircusTent = new("\U0001F3AA");

        /// <summary>
        /// 🎭 - PERFORMING ARTS
        /// </summary>
        public static readonly Emoji PerformingArts = new("\U0001F3AD");

        /// <summary>
        /// 🖼 - FRAME WITH PICTURE
        /// </summary>
        public static readonly Emoji FrameWithPicture = new("\U0001F5BC");

        /// <summary>
        /// 🎨 - ARTIST PALETTE
        /// </summary>
        public static readonly Emoji ArtistPalette = new("\U0001F3A8");

        /// <summary>
        /// 🎰 - SLOT MACHINE
        /// </summary>
        public static readonly Emoji SlotMachine = new("\U0001F3B0");

        /// <summary>
        /// 🚂 - STEAM LOCOMOTIVE locomotive
        /// </summary>
        public static readonly Emoji SteamLocomotiveLocomotive = new("\U0001F682");

        /// <summary>
        /// 🚃 - RAILWAY CAR
        /// </summary>
        public static readonly Emoji RailwayCar = new("\U0001F683");

        /// <summary>
        /// 🚄 - HIGH-SPEED TRAIN
        /// </summary>
        public static readonly Emoji HighSpeedTrain = new("\U0001F684");

        /// <summary>
        /// 🚅 - HIGH-SPEED TRAIN WITH BULLET NOSE
        /// </summary>
        public static readonly Emoji HighSpeedTrainWithBulletNose = new("\U0001F685");

        /// <summary>
        /// 🚆 - TRAIN
        /// </summary>
        public static readonly Emoji Train = new("\U0001F686");

        /// <summary>
        /// 🚇 - METRO
        /// </summary>
        public static readonly Emoji Metro = new("\U0001F687");

        /// <summary>
        /// 🚈 - LIGHT RAIL
        /// </summary>
        public static readonly Emoji LightRail = new("\U0001F688");

        /// <summary>
        /// 🚉 - STATION
        /// </summary>
        public static readonly Emoji Station = new("\U0001F689");

        /// <summary>
        /// 🚊 - TRAM
        /// </summary>
        public static readonly Emoji Tram = new("\U0001F68A");

        /// <summary>
        /// 🚝 - MONORAIL
        /// </summary>
        public static readonly Emoji Monorail = new("\U0001F69D");

        /// <summary>
        /// 🚞 - MOUNTAIN RAILWAY
        /// </summary>
        public static readonly Emoji MountainRailway = new("\U0001F69E");

        /// <summary>
        /// 🚋 - TRAM CAR
        /// </summary>
        public static readonly Emoji TramCar = new("\U0001F68B");

        /// <summary>
        /// 🚌 - BUS
        /// </summary>
        public static readonly Emoji Bus = new("\U0001F68C");

        /// <summary>
        /// 🚍 - ONCOMING BUS
        /// </summary>
        public static readonly Emoji OncomingBus = new("\U0001F68D");

        /// <summary>
        /// 🚎 - TROLLEYBUS
        /// </summary>
        public static readonly Emoji Trolleybus = new("\U0001F68E");

        /// <summary>
        /// 🚏 - BUS STOP
        /// </summary>
        public static readonly Emoji BusStop = new("\U0001F68F");

        /// <summary>
        /// 🚐 - MINIBUS
        /// </summary>
        public static readonly Emoji Minibus = new("\U0001F690");

        /// <summary>
        /// 🚑 - AMBULANCE
        /// </summary>
        public static readonly Emoji Ambulance = new("\U0001F691");

        /// <summary>
        /// 🚒 - FIRE ENGINE
        /// </summary>
        public static readonly Emoji FireEngine = new("\U0001F692");

        /// <summary>
        /// 🚓 - POLICE CAR
        /// </summary>
        public static readonly Emoji PoliceCar = new("\U0001F693");

        /// <summary>
        /// 🚔 - ONCOMING POLICE CAR
        /// </summary>
        public static readonly Emoji OncomingPoliceCar = new("\U0001F694");

        /// <summary>
        /// 🚕 - TAXI
        /// </summary>
        public static readonly Emoji Taxi = new("\U0001F695");

        /// <summary>
        /// 🚖 - ONCOMING TAXI
        /// </summary>
        public static readonly Emoji OncomingTaxi = new("\U0001F696");

        /// <summary>
        /// 🚗 - AUTOMOBILE
        /// </summary>
        public static readonly Emoji Automobile = new("\U0001F697");

        /// <summary>
        /// 🚘 - ONCOMING AUTOMOBILE
        /// </summary>
        public static readonly Emoji OncomingAutomobile = new("\U0001F698");

        /// <summary>
        /// 🚙 - RECREATIONAL VEHICLE
        /// </summary>
        public static readonly Emoji RecreationalVehicle = new("\U0001F699");

        /// <summary>
        /// 🚚 - DELIVERY TRUCK
        /// </summary>
        public static readonly Emoji DeliveryTruck = new("\U0001F69A");

        /// <summary>
        /// 🚛 - ARTICULATED LORRY
        /// </summary>
        public static readonly Emoji ArticulatedLorry = new("\U0001F69B");

        /// <summary>
        /// 🚜 - TRACTOR
        /// </summary>
        public static readonly Emoji Tractor = new("\U0001F69C");

        /// <summary>
        /// 🚲 - BICYCLE
        /// </summary>
        public static readonly Emoji Bicycle = new("\U0001F6B2");

        /// <summary>
        /// ⛽ - FUEL PUMP
        /// </summary>
        public static readonly Emoji FuelPump = new("\U000026FD");

        /// <summary>
        /// 🛣 - MOTORWAY
        /// </summary>
        public static readonly Emoji Motorway = new("\U0001F6E3");

        /// <summary>
        /// 🛤 - RAILWAY TRACK
        /// </summary>
        public static readonly Emoji RailwayTrack = new("\U0001F6E4");

        /// <summary>
        /// 🚨 - POLICE CARS REVOLVING LIGHT police cars light
        /// </summary>
        public static readonly Emoji PoliceCarsRevolvingLightPoliceCarsLight = new("\U0001F6A8");

        /// <summary>
        /// 🚥 - HORIZONTAL TRAFFIC LIGHT
        /// </summary>
        public static readonly Emoji HorizontalTrafficLight = new("\U0001F6A5");

        /// <summary>
        /// 🚦 - VERTICAL TRAFFIC LIGHT
        /// </summary>
        public static readonly Emoji VerticalTrafficLight = new("\U0001F6A6");

        /// <summary>
        /// 🚧 - CONSTRUCTION SIGN construction
        /// </summary>
        public static readonly Emoji ConstructionSignConstruction = new("\U0001F6A7");

        /// <summary>
        /// 🛑 - OCTAGONAL SIGN
        /// </summary>
        public static readonly Emoji OctagonalSign = new("\U0001F6D1");

        /// <summary>
        /// 🛴 - SCOOTER
        /// </summary>
        public static readonly Emoji Scooter = new("\U0001F6F4");

        /// <summary>
        /// 🛵 - MOTOR SCOOTER
        /// </summary>
        public static readonly Emoji MotorScooter = new("\U0001F6F5");

        /// <summary>
        /// ⚓ - ANCHOR
        /// </summary>
        public static readonly Emoji Anchor = new("\U00002693");

        /// <summary>
        /// ⛵ - SAILBOAT
        /// </summary>
        public static readonly Emoji Sailboat = new("\U000026F5");

        /// <summary>
        /// 🚣 - ROWBOAT
        /// </summary>
        public static readonly Emoji Rowboat = new("\U0001F6A3");

        /// <summary>
        /// 🛶 - CANOE
        /// </summary>
        public static readonly Emoji Canoe = new("\U0001F6F6");

        /// <summary>
        /// 🚤 - SPEEDBOAT
        /// </summary>
        public static readonly Emoji Speedboat = new("\U0001F6A4");

        /// <summary>
        /// 🛳 - PASSENGER SHIP
        /// </summary>
        public static readonly Emoji PassengerShip = new("\U0001F6F3");

        /// <summary>
        /// ⛴ - FERRY
        /// </summary>
        public static readonly Emoji Ferry = new("\U000026F4");

        /// <summary>
        /// 🛥 - MOTOR BOAT
        /// </summary>
        public static readonly Emoji MotorBoat = new("\U0001F6E5");

        /// <summary>
        /// 🚢 - SHIP
        /// </summary>
        public static readonly Emoji Ship = new("\U0001F6A2");

        /// <summary>
        /// ✈ - AIRPLANE
        /// </summary>
        public static readonly Emoji Airplane = new("\U00002708");

        /// <summary>
        /// 🛩 - SMALL AIRPLANE
        /// </summary>
        public static readonly Emoji SmallAirplane = new("\U0001F6E9");

        /// <summary>
        /// 🛫 - AIRPLANE DEPARTURE
        /// </summary>
        public static readonly Emoji AirplaneDeparture = new("\U0001F6EB");

        /// <summary>
        /// 🛬 - AIRPLANE ARRIVING airplane arrival
        /// </summary>
        public static readonly Emoji AirplaneArrivingAirplaneArrival = new("\U0001F6EC");

        /// <summary>
        /// 💺 - SEAT
        /// </summary>
        public static readonly Emoji Seat = new("\U0001F4BA");

        /// <summary>
        /// 🚁 - HELICOPTER
        /// </summary>
        public static readonly Emoji Helicopter = new("\U0001F681");

        /// <summary>
        /// 🚟 - SUSPENSION RAILWAY
        /// </summary>
        public static readonly Emoji SuspensionRailway = new("\U0001F69F");

        /// <summary>
        /// 🚠 - MOUNTAIN CABLEWAY
        /// </summary>
        public static readonly Emoji MountainCableway = new("\U0001F6A0");

        /// <summary>
        /// 🚡 - AERIAL TRAMWAY
        /// </summary>
        public static readonly Emoji AerialTramway = new("\U0001F6A1");

        /// <summary>
        /// 🚀 - ROCKET
        /// </summary>
        public static readonly Emoji Rocket = new("\U0001F680");

        /// <summary>
        /// 🛰 - SATELLITE
        /// </summary>
        public static readonly Emoji Satellite = new("\U0001F6F0");

        /// <summary>
        /// 🛎 - BELLHOP BELL
        /// </summary>
        public static readonly Emoji BellhopBell = new("\U0001F6CE");

        /// <summary>
        /// 🚪 - DOOR
        /// </summary>
        public static readonly Emoji Door = new("\U0001F6AA");

        /// <summary>
        /// 🛌 - SLEEPING ACCOMMODATION person in bed
        /// </summary>
        public static readonly Emoji SleepingAccommodationPersonInBed = new("\U0001F6CC");

        /// <summary>
        /// 🛏 - BED
        /// </summary>
        public static readonly Emoji Bed = new("\U0001F6CF");

        /// <summary>
        /// 🛋 - COUCH AND LAMP
        /// </summary>
        public static readonly Emoji CouchAndLamp = new("\U0001F6CB");

        /// <summary>
        /// 🚽 - TOILET
        /// </summary>
        public static readonly Emoji Toilet = new("\U0001F6BD");

        /// <summary>
        /// 🚿 - SHOWER
        /// </summary>
        public static readonly Emoji Shower = new("\U0001F6BF");

        /// <summary>
        /// 🛀 - BATH person taking bath
        /// </summary>
        public static readonly Emoji BathPersonTakingBath = new("\U0001F6C0");

        /// <summary>
        /// 🛁 - BATHTUB
        /// </summary>
        public static readonly Emoji Bathtub = new("\U0001F6C1");

        /// <summary>
        /// ⌛ - HOURGLASS
        /// </summary>
        public static readonly Emoji Hourglass = new("\U0000231B");

        /// <summary>
        /// ⏳ - HOURGLASS WITH FLOWING SAND
        /// </summary>
        public static readonly Emoji HourglassWithFlowingSand = new("\U000023F3");

        /// <summary>
        /// ⌚ - WATCH
        /// </summary>
        public static readonly Emoji Watch = new("\U0000231A");

        /// <summary>
        /// ⏰ - ALARM CLOCK
        /// </summary>
        public static readonly Emoji AlarmClock = new("\U000023F0");

        /// <summary>
        /// ⏱ - STOPWATCH
        /// </summary>
        public static readonly Emoji Stopwatch = new("\U000023F1");

        /// <summary>
        /// ⏲ - TIMER CLOCK
        /// </summary>
        public static readonly Emoji TimerClock = new("\U000023F2");

        /// <summary>
        /// 🕰 - MANTELPIECE CLOCK
        /// </summary>
        public static readonly Emoji MantelpieceClock = new("\U0001F570");

        /// <summary>
        /// 🕛 - CLOCK FACE TWELVE OCLOCK twelve oclock
        /// </summary>
        public static readonly Emoji ClockFaceTwelveOclockTwelveOclock = new("\U0001F55B");

        /// <summary>
        /// 🕧 - CLOCK FACE TWELVE-THIRTY twelve-thirty
        /// </summary>
        public static readonly Emoji ClockFaceTwelveThirtyTwelveThirty = new("\U0001F567");

        /// <summary>
        /// 🕐 - CLOCK FACE ONE OCLOCK one oclock
        /// </summary>
        public static readonly Emoji ClockFaceOneOclockOneOclock = new("\U0001F550");

        /// <summary>
        /// 🕜 - CLOCK FACE ONE-THIRTY one-thirty
        /// </summary>
        public static readonly Emoji ClockFaceOneThirtyOneThirty = new("\U0001F55C");

        /// <summary>
        /// 🕑 - CLOCK FACE TWO OCLOCK two oclock
        /// </summary>
        public static readonly Emoji ClockFaceTwoOclockTwoOclock = new("\U0001F551");

        /// <summary>
        /// 🕝 - CLOCK FACE TWO-THIRTY two-thirty
        /// </summary>
        public static readonly Emoji ClockFaceTwoThirtyTwoThirty = new("\U0001F55D");

        /// <summary>
        /// 🕒 - CLOCK FACE THREE OCLOCK three oclock
        /// </summary>
        public static readonly Emoji ClockFaceThreeOclockThreeOclock = new("\U0001F552");

        /// <summary>
        /// 🕞 - CLOCK FACE THREE-THIRTY three-thirty
        /// </summary>
        public static readonly Emoji ClockFaceThreeThirtyThreeThirty = new("\U0001F55E");

        /// <summary>
        /// 🕓 - CLOCK FACE FOUR OCLOCK four oclock
        /// </summary>
        public static readonly Emoji ClockFaceFourOclockFourOclock = new("\U0001F553");

        /// <summary>
        /// 🕟 - CLOCK FACE FOUR-THIRTY four-thirty
        /// </summary>
        public static readonly Emoji ClockFaceFourThirtyFourThirty = new("\U0001F55F");

        /// <summary>
        /// 🕔 - CLOCK FACE FIVE OCLOCK five oclock
        /// </summary>
        public static readonly Emoji ClockFaceFiveOclockFiveOclock = new("\U0001F554");

        /// <summary>
        /// 🕠 - CLOCK FACE FIVE-THIRTY five-thirty
        /// </summary>
        public static readonly Emoji ClockFaceFiveThirtyFiveThirty = new("\U0001F560");

        /// <summary>
        /// 🕕 - CLOCK FACE SIX OCLOCK six oclock
        /// </summary>
        public static readonly Emoji ClockFaceSixOclockSixOclock = new("\U0001F555");

        /// <summary>
        /// 🕡 - CLOCK FACE SIX-THIRTY six-thirty
        /// </summary>
        public static readonly Emoji ClockFaceSixThirtySixThirty = new("\U0001F561");

        /// <summary>
        /// 🕖 - CLOCK FACE SEVEN OCLOCK seven oclock
        /// </summary>
        public static readonly Emoji ClockFaceSevenOclockSevenOclock = new("\U0001F556");

        /// <summary>
        /// 🕢 - CLOCK FACE SEVEN-THIRTY seven-thirty
        /// </summary>
        public static readonly Emoji ClockFaceSevenThirtySevenThirty = new("\U0001F562");

        /// <summary>
        /// 🕗 - CLOCK FACE EIGHT OCLOCK eight oclock
        /// </summary>
        public static readonly Emoji ClockFaceEightOclockEightOclock = new("\U0001F557");

        /// <summary>
        /// 🕣 - CLOCK FACE EIGHT-THIRTY eight-thirty
        /// </summary>
        public static readonly Emoji ClockFaceEightThirtyEightThirty = new("\U0001F563");

        /// <summary>
        /// 🕘 - CLOCK FACE NINE OCLOCK nine oclock
        /// </summary>
        public static readonly Emoji ClockFaceNineOclockNineOclock = new("\U0001F558");

        /// <summary>
        /// 🕤 - CLOCK FACE NINE-THIRTY nine-thirty
        /// </summary>
        public static readonly Emoji ClockFaceNineThirtyNineThirty = new("\U0001F564");

        /// <summary>
        /// 🕙 - CLOCK FACE TEN OCLOCK ten oclock
        /// </summary>
        public static readonly Emoji ClockFaceTenOclockTenOclock = new("\U0001F559");

        /// <summary>
        /// 🕥 - CLOCK FACE TEN-THIRTY ten-thirty
        /// </summary>
        public static readonly Emoji ClockFaceTenThirtyTenThirty = new("\U0001F565");

        /// <summary>
        /// 🕚 - CLOCK FACE ELEVEN OCLOCK eleven oclock
        /// </summary>
        public static readonly Emoji ClockFaceElevenOclockElevenOclock = new("\U0001F55A");

        /// <summary>
        /// 🕦 - CLOCK FACE ELEVEN-THIRTY eleven-thirty
        /// </summary>
        public static readonly Emoji ClockFaceElevenThirtyElevenThirty = new("\U0001F566");

        /// <summary>
        /// 🌑 - NEW MOON SYMBOL new moon
        /// </summary>
        public static readonly Emoji NewMoonSymbolNewMoon = new("\U0001F311");

        /// <summary>
        /// 🌒 - WAXING CRESCENT MOON SYMBOL waxing crescent moon
        /// </summary>
        public static readonly Emoji WaxingCrescentMoonSymbolWaxingCrescentMoon = new("\U0001F312");

        /// <summary>
        /// 🌓 - FIRST QUARTER MOON SYMBOL first quarter moon
        /// </summary>
        public static readonly Emoji FirstQuarterMoonSymbolFirstQuarterMoon = new("\U0001F313");

        /// <summary>
        /// 🌔 - WAXING GIBBOUS MOON SYMBOL waxing gibbous moon
        /// </summary>
        public static readonly Emoji WaxingGibbousMoonSymbolWaxingGibbousMoon = new("\U0001F314");

        /// <summary>
        /// 🌕 - FULL MOON SYMBOL full moon
        /// </summary>
        public static readonly Emoji FullMoonSymbolFullMoon = new("\U0001F315");

        /// <summary>
        /// 🌖 - WANING GIBBOUS MOON SYMBOL waning gibbous moon
        /// </summary>
        public static readonly Emoji WaningGibbousMoonSymbolWaningGibbousMoon = new("\U0001F316");

        /// <summary>
        /// 🌗 - LAST QUARTER MOON SYMBOL last quarter moon
        /// </summary>
        public static readonly Emoji LastQuarterMoonSymbolLastQuarterMoon = new("\U0001F317");

        /// <summary>
        /// 🌘 - WANING CRESCENT MOON SYMBOL waning crescent moon
        /// </summary>
        public static readonly Emoji WaningCrescentMoonSymbolWaningCrescentMoon = new("\U0001F318");

        /// <summary>
        /// 🌙 - CRESCENT MOON
        /// </summary>
        public static readonly Emoji CrescentMoon = new("\U0001F319");

        /// <summary>
        /// 🌚 - NEW MOON WITH FACE new moon face
        /// </summary>
        public static readonly Emoji NewMoonWithFaceNewMoonFace = new("\U0001F31A");

        /// <summary>
        /// 🌛 - FIRST QUARTER MOON WITH FACE
        /// </summary>
        public static readonly Emoji FirstQuarterMoonWithFace = new("\U0001F31B");

        /// <summary>
        /// 🌜 - LAST QUARTER MOON WITH FACE
        /// </summary>
        public static readonly Emoji LastQuarterMoonWithFace = new("\U0001F31C");

        /// <summary>
        /// 🌡 - THERMOMETER
        /// </summary>
        public static readonly Emoji Thermometer = new("\U0001F321");

        /// <summary>
        /// ☀ - BLACK SUN WITH RAYS sun
        /// </summary>
        public static readonly Emoji BlackSunWithRaysSun = new("\U00002600");

        /// <summary>
        /// 🌝 - FULL MOON WITH FACE
        /// </summary>
        public static readonly Emoji FullMoonWithFace = new("\U0001F31D");

        /// <summary>
        /// 🌞 - SUN WITH FACE
        /// </summary>
        public static readonly Emoji SunWithFace = new("\U0001F31E");

        /// <summary>
        /// ⭐ - WHITE MEDIUM STAR
        /// </summary>
        public static readonly Emoji WhiteMediumStar = new("\U00002B50");

        /// <summary>
        /// 🌟 - GLOWING STAR
        /// </summary>
        public static readonly Emoji GlowingStar = new("\U0001F31F");

        /// <summary>
        /// 🌠 - SHOOTING STAR
        /// </summary>
        public static readonly Emoji ShootingStar = new("\U0001F320");

        /// <summary>
        /// ☁ - CLOUD
        /// </summary>
        public static readonly Emoji Cloud = new("\U00002601");

        /// <summary>
        /// ⛅ - SUN BEHIND CLOUD
        /// </summary>
        public static readonly Emoji SunBehindCloud = new("\U000026C5");

        /// <summary>
        /// ⛈ - THUNDER CLOUD AND RAIN cloud with lightning and rain
        /// </summary>
        public static readonly Emoji ThunderCloudAndRainCloudWithLightningAndRain = new("\U000026C8");

        /// <summary>
        /// 🌤 - WHITE SUN WITH SMALL CLOUD sun behind small cloud
        /// </summary>
        public static readonly Emoji WhiteSunWithSmallCloudSunBehindSmallCloud = new("\U0001F324");

        /// <summary>
        /// 🌥 - WHITE SUN BEHIND CLOUD sun behind large cloud
        /// </summary>
        public static readonly Emoji WhiteSunBehindCloudSunBehindLargeCloud = new("\U0001F325");

        /// <summary>
        /// 🌦 - WHITE SUN BEHIND CLOUD WITH RAIN sun behind cloud with rain
        /// </summary>
        public static readonly Emoji WhiteSunBehindCloudWithRainSunBehindCloudWithRain = new("\U0001F326");

        /// <summary>
        /// 🌧 - CLOUD WITH RAIN
        /// </summary>
        public static readonly Emoji CloudWithRain = new("\U0001F327");

        /// <summary>
        /// 🌨 - CLOUD WITH SNOW
        /// </summary>
        public static readonly Emoji CloudWithSnow = new("\U0001F328");

        /// <summary>
        /// 🌩 - CLOUD WITH LIGHTNING
        /// </summary>
        public static readonly Emoji CloudWithLightning = new("\U0001F329");

        /// <summary>
        /// 🌪 - CLOUD WITH TORNADO tornado
        /// </summary>
        public static readonly Emoji CloudWithTornadoTornado = new("\U0001F32A");

        /// <summary>
        /// 🌫 - FOG
        /// </summary>
        public static readonly Emoji Fog = new("\U0001F32B");

        /// <summary>
        /// 🌬 - WIND BLOWING FACE wind face
        /// </summary>
        public static readonly Emoji WindBlowingFaceWindFace = new("\U0001F32C");

        /// <summary>
        /// 🌀 - CYCLONE
        /// </summary>
        public static readonly Emoji Cyclone = new("\U0001F300");

        /// <summary>
        /// 🌈 - RAINBOW
        /// </summary>
        public static readonly Emoji Rainbow = new("\U0001F308");

        /// <summary>
        /// 🌂 - CLOSED UMBRELLA
        /// </summary>
        public static readonly Emoji ClosedUmbrella = new("\U0001F302");

        /// <summary>
        /// ☂ - UMBRELLA
        /// </summary>
        public static readonly Emoji Umbrella = new("\U00002602");

        /// <summary>
        /// ☔ - UMBRELLA WITH RAIN DROPS
        /// </summary>
        public static readonly Emoji UmbrellaWithRainDrops = new("\U00002614");

        /// <summary>
        /// ⛱ - UMBRELLA ON GROUND
        /// </summary>
        public static readonly Emoji UmbrellaOnGround = new("\U000026F1");

        /// <summary>
        /// ⚡ - HIGH VOLTAGE SIGN high voltage
        /// </summary>
        public static readonly Emoji HighVoltageSignHighVoltage = new("\U000026A1");

        /// <summary>
        /// ❄ - SNOWFLAKE
        /// </summary>
        public static readonly Emoji Snowflake = new("\U00002744");

        /// <summary>
        /// ☃ - SNOWMAN
        /// </summary>
        public static readonly Emoji Snowman = new("\U00002603");

        /// <summary>
        /// ⛄ - SNOWMAN WITHOUT SNOW
        /// </summary>
        public static readonly Emoji SnowmanWithoutSnow = new("\U000026C4");

        /// <summary>
        /// ☄ - COMET
        /// </summary>
        public static readonly Emoji Comet = new("\U00002604");

        /// <summary>
        /// 🔥 - FIRE
        /// </summary>
        public static readonly Emoji Fire = new("\U0001F525");

        /// <summary>
        /// 💧 - DROPLET
        /// </summary>
        public static readonly Emoji Droplet = new("\U0001F4A7");

        /// <summary>
        /// 🌊 - WATER WAVE
        /// </summary>
        public static readonly Emoji WaterWave = new("\U0001F30A");
    }

    /// <summary>
    /// Activities
    /// </summary>
    public static class Activities
    {
        /// <summary>
        /// 🎃 - JACK-O-LANTERN
        /// </summary>
        public static readonly Emoji JackOLantern = new("\U0001F383");

        /// <summary>
        /// 🎄 - CHRISTMAS TREE
        /// </summary>
        public static readonly Emoji ChristmasTree = new("\U0001F384");

        /// <summary>
        /// 🎆 - FIREWORKS
        /// </summary>
        public static readonly Emoji Fireworks = new("\U0001F386");

        /// <summary>
        /// 🎇 - FIREWORK SPARKLER sparkler
        /// </summary>
        public static readonly Emoji FireworkSparklerSparkler = new("\U0001F387");

        /// <summary>
        /// ✨ - SPARKLES
        /// </summary>
        public static readonly Emoji Sparkles = new("\U00002728");

        /// <summary>
        /// 🎈 - BALLOON
        /// </summary>
        public static readonly Emoji Balloon = new("\U0001F388");

        /// <summary>
        /// 🎉 - PARTY POPPER
        /// </summary>
        public static readonly Emoji PartyPopper = new("\U0001F389");

        /// <summary>
        /// 🎊 - CONFETTI BALL
        /// </summary>
        public static readonly Emoji ConfettiBall = new("\U0001F38A");

        /// <summary>
        /// 🎋 - TANABATA TREE
        /// </summary>
        public static readonly Emoji TanabataTree = new("\U0001F38B");

        /// <summary>
        /// 🎍 - PINE DECORATION
        /// </summary>
        public static readonly Emoji PineDecoration = new("\U0001F38D");

        /// <summary>
        /// 🎎 - JAPANESE DOLLS
        /// </summary>
        public static readonly Emoji JapaneseDolls = new("\U0001F38E");

        /// <summary>
        /// 🎏 - CARP STREAMER
        /// </summary>
        public static readonly Emoji CarpStreamer = new("\U0001F38F");

        /// <summary>
        /// 🎐 - WIND CHIME
        /// </summary>
        public static readonly Emoji WindChime = new("\U0001F390");

        /// <summary>
        /// 🎑 - MOON VIEWING CEREMONY moon ceremony
        /// </summary>
        public static readonly Emoji MoonViewingCeremonyMoonCeremony = new("\U0001F391");

        /// <summary>
        /// 🎀 - RIBBON
        /// </summary>
        public static readonly Emoji Ribbon = new("\U0001F380");

        /// <summary>
        /// 🎁 - WRAPPED PRESENT
        /// </summary>
        public static readonly Emoji WrappedPresent = new("\U0001F381");

        /// <summary>
        /// 🎗 - REMINDER RIBBON
        /// </summary>
        public static readonly Emoji ReminderRibbon = new("\U0001F397");

        /// <summary>
        /// 🎟 - ADMISSION TICKETS
        /// </summary>
        public static readonly Emoji AdmissionTickets = new("\U0001F39F");

        /// <summary>
        /// 🎫 - TICKET
        /// </summary>
        public static readonly Emoji Ticket = new("\U0001F3AB");

        /// <summary>
        /// 🎖 - MILITARY MEDAL
        /// </summary>
        public static readonly Emoji MilitaryMedal = new("\U0001F396");

        /// <summary>
        /// 🏆 - TROPHY
        /// </summary>
        public static readonly Emoji Trophy = new("\U0001F3C6");

        /// <summary>
        /// 🏅 - SPORTS MEDAL
        /// </summary>
        public static readonly Emoji SportsMedal = new("\U0001F3C5");

        /// <summary>
        /// 🥇 - FIRST PLACE MEDAL
        /// </summary>
        public static readonly Emoji FirstPlaceMedal = new("\U0001F947");

        /// <summary>
        /// 🥈 - SECOND PLACE MEDAL
        /// </summary>
        public static readonly Emoji SecondPlaceMedal = new("\U0001F948");

        /// <summary>
        /// 🥉 - THIRD PLACE MEDAL
        /// </summary>
        public static readonly Emoji ThirdPlaceMedal = new("\U0001F949");

        /// <summary>
        /// ⚽ - SOCCER BALL
        /// </summary>
        public static readonly Emoji SoccerBall = new("\U000026BD");

        /// <summary>
        /// ⚾ - BASEBALL
        /// </summary>
        public static readonly Emoji Baseball = new("\U000026BE");

        /// <summary>
        /// 🏀 - BASKETBALL AND HOOP basketball
        /// </summary>
        public static readonly Emoji BasketballAndHoopBasketball = new("\U0001F3C0");

        /// <summary>
        /// 🏐 - VOLLEYBALL
        /// </summary>
        public static readonly Emoji Volleyball = new("\U0001F3D0");

        /// <summary>
        /// 🏈 - AMERICAN FOOTBALL
        /// </summary>
        public static readonly Emoji AmericanFootball = new("\U0001F3C8");

        /// <summary>
        /// 🏉 - RUGBY FOOTBALL
        /// </summary>
        public static readonly Emoji RugbyFootball = new("\U0001F3C9");

        /// <summary>
        /// 🎾 - TENNIS RACQUET AND BALL tennis
        /// </summary>
        public static readonly Emoji TennisRacquetAndBallTennis = new("\U0001F3BE");

        /// <summary>
        /// 🎱 - BILLIARDS
        /// </summary>
        public static readonly Emoji Billiards = new("\U0001F3B1");

        /// <summary>
        /// 🎳 - BOWLING
        /// </summary>
        public static readonly Emoji Bowling = new("\U0001F3B3");

        /// <summary>
        /// 🏏 - CRICKET BAT AND BALL cricket
        /// </summary>
        public static readonly Emoji CricketBatAndBallCricket = new("\U0001F3CF");

        /// <summary>
        /// 🏑 - FIELD HOCKEY STICK AND BALL field hockey
        /// </summary>
        public static readonly Emoji FieldHockeyStickAndBallFieldHockey = new("\U0001F3D1");

        /// <summary>
        /// 🏒 - ICE HOCKEY STICK AND PUCK
        /// </summary>
        public static readonly Emoji IceHockeyStickAndPuck = new("\U0001F3D2");

        /// <summary>
        /// 🏓 - TABLE TENNIS PADDLE AND BALL ping pong
        /// </summary>
        public static readonly Emoji TableTennisPaddleAndBallPingPong = new("\U0001F3D3");

        /// <summary>
        /// 🏸 - BADMINTON RACQUET AND SHUTTLECOCK badminton
        /// </summary>
        public static readonly Emoji BadmintonRacquetAndShuttlecockBadminton = new("\U0001F3F8");

        /// <summary>
        /// 🥊 - BOXING GLOVE
        /// </summary>
        public static readonly Emoji BoxingGlove = new("\U0001F94A");

        /// <summary>
        /// 🥋 - MARTIAL ARTS UNIFORM
        /// </summary>
        public static readonly Emoji MartialArtsUniform = new("\U0001F94B");

        /// <summary>
        /// ⛳ - FLAG IN HOLE
        /// </summary>
        public static readonly Emoji FlagInHole = new("\U000026F3");

        /// <summary>
        /// 🏌 - GOLFER
        /// </summary>
        public static readonly Emoji Golfer = new("\U0001F3CC");

        /// <summary>
        /// ⛸ - ICE SKATE
        /// </summary>
        public static readonly Emoji IceSkate = new("\U000026F8");

        /// <summary>
        /// 🎣 - FISHING POLE AND FISH fishing pole
        /// </summary>
        public static readonly Emoji FishingPoleAndFishFishingPole = new("\U0001F3A3");

        /// <summary>
        /// 🎽 - RUNNING SHIRT WITH SASH running shirt
        /// </summary>
        public static readonly Emoji RunningShirtWithSashRunningShirt = new("\U0001F3BD");

        /// <summary>
        /// 🎿 - SKI AND SKI BOOT skis
        /// </summary>
        public static readonly Emoji SkiAndSkiBootSkis = new("\U0001F3BF");

        /// <summary>
        /// ⛷ - SKIER
        /// </summary>
        public static readonly Emoji Skier = new("\U000026F7");

        /// <summary>
        /// 🏂 - SNOWBOARDER
        /// </summary>
        public static readonly Emoji Snowboarder = new("\U0001F3C2");

        /// <summary>
        /// 🏄 - SURFER
        /// </summary>
        public static readonly Emoji Surfer = new("\U0001F3C4");

        /// <summary>
        /// 🏇 - HORSE RACING
        /// </summary>
        public static readonly Emoji HorseRacing = new("\U0001F3C7");

        /// <summary>
        /// 🏊 - SWIMMER
        /// </summary>
        public static readonly Emoji Swimmer = new("\U0001F3CA");

        /// <summary>
        /// ⛹ - PERSON WITH BALL
        /// </summary>
        public static readonly Emoji PersonWithBall = new("\U000026F9");

        /// <summary>
        /// 🏋 - WEIGHT LIFTER
        /// </summary>
        public static readonly Emoji WeightLifter = new("\U0001F3CB");

        /// <summary>
        /// 🚴 - BICYCLIST
        /// </summary>
        public static readonly Emoji Bicyclist = new("\U0001F6B4");

        /// <summary>
        /// 🚵 - MOUNTAIN BICYCLIST mountain biker
        /// </summary>
        public static readonly Emoji MountainBicyclistMountainBiker = new("\U0001F6B5");

        /// <summary>
        /// 🏎 - RACING CAR
        /// </summary>
        public static readonly Emoji RacingCar = new("\U0001F3CE");

        /// <summary>
        /// 🏍 - RACING MOTORCYCLE motorcycle
        /// </summary>
        public static readonly Emoji RacingMotorcycleMotorcycle = new("\U0001F3CD");

        /// <summary>
        /// 🤸 - PERSON DOING CARTWHEEL
        /// </summary>
        public static readonly Emoji PersonDoingCartwheel = new("\U0001F938");

        /// <summary>
        /// 🤼 - WRESTLERS
        /// </summary>
        public static readonly Emoji Wrestlers = new("\U0001F93C");

        /// <summary>
        /// 🤽 - WATER POLO
        /// </summary>
        public static readonly Emoji WaterPolo = new("\U0001F93D");

        /// <summary>
        /// 🤾 - HANDBALL
        /// </summary>
        public static readonly Emoji Handball = new("\U0001F93E");

        /// <summary>
        /// 🤺 - FENCER
        /// </summary>
        public static readonly Emoji Fencer = new("\U0001F93A");

        /// <summary>
        /// 🥅 - GOAL NET
        /// </summary>
        public static readonly Emoji GoalNet = new("\U0001F945");

        /// <summary>
        /// 🤹 - JUGGLING
        /// </summary>
        public static readonly Emoji Juggling = new("\U0001F939");

        /// <summary>
        /// 🎯 - DIRECT HIT
        /// </summary>
        public static readonly Emoji DirectHit = new("\U0001F3AF");

        /// <summary>
        /// 🎮 - VIDEO GAME
        /// </summary>
        public static readonly Emoji VideoGame = new("\U0001F3AE");

        /// <summary>
        /// 🕹 - JOYSTICK
        /// </summary>
        public static readonly Emoji Joystick = new("\U0001F579");

        /// <summary>
        /// 🎲 - GAME DIE
        /// </summary>
        public static readonly Emoji GameDie = new("\U0001F3B2");

        /// <summary>
        /// ♠ - BLACK SPADE SUIT spade suit
        /// </summary>
        public static readonly Emoji BlackSpadeSuitSpadeSuit = new("\U00002660");

        /// <summary>
        /// ♥ - BLACK HEART SUIT heart suit
        /// </summary>
        public static readonly Emoji BlackHeartSuitHeartSuit = new("\U00002665");

        /// <summary>
        /// ♦ - BLACK DIAMOND SUIT diamond suit
        /// </summary>
        public static readonly Emoji BlackDiamondSuitDiamondSuit = new("\U00002666");

        /// <summary>
        /// ♣ - BLACK CLUB SUIT club suit
        /// </summary>
        public static readonly Emoji BlackClubSuitClubSuit = new("\U00002663");

        /// <summary>
        /// 🃏 - PLAYING CARD BLACK JOKER joker
        /// </summary>
        public static readonly Emoji PlayingCardBlackJokerJoker = new("\U0001F0CF");

        /// <summary>
        /// 🀄 - MAHJONG TILE RED DRAGON mahjong red dragon
        /// </summary>
        public static readonly Emoji MahjongTileRedDragonMahjongRedDragon = new("\U0001F004");

        /// <summary>
        /// 🎴 - FLOWER PLAYING CARDS
        /// </summary>
        public static readonly Emoji FlowerPlayingCards = new("\U0001F3B4");
    }

    /// <summary>
    /// Objects
    /// </summary>
    public static class Objects
    {
        /// <summary>
        /// 🔇 - SPEAKER WITH CANCELLATION STROKE speaker off
        /// </summary>
        public static readonly Emoji SpeakerWithCancellationStrokeSpeakerOff = new("\U0001F507");

        /// <summary>
        /// 🔈 - SPEAKER
        /// </summary>
        public static readonly Emoji Speaker = new("\U0001F508");

        /// <summary>
        /// 🔉 - SPEAKER WITH ONE SOUND WAVE speaker on
        /// </summary>
        public static readonly Emoji SpeakerWithOneSoundWaveSpeakerOn = new("\U0001F509");

        /// <summary>
        /// 🔊 - SPEAKER WITH THREE SOUND WAVES speaker loud
        /// </summary>
        public static readonly Emoji SpeakerWithThreeSoundWavesSpeakerLoud = new("\U0001F50A");

        /// <summary>
        /// 📢 - PUBLIC ADDRESS LOUDSPEAKER loudspeaker
        /// </summary>
        public static readonly Emoji PublicAddressLoudspeakerLoudspeaker = new("\U0001F4E2");

        /// <summary>
        /// 📣 - CHEERING MEGAPHONE megaphone
        /// </summary>
        public static readonly Emoji CheeringMegaphoneMegaphone = new("\U0001F4E3");

        /// <summary>
        /// 📯 - POSTAL HORN
        /// </summary>
        public static readonly Emoji PostalHorn = new("\U0001F4EF");

        /// <summary>
        /// 🔔 - BELL
        /// </summary>
        public static readonly Emoji Bell = new("\U0001F514");

        /// <summary>
        /// 🔕 - BELL WITH CANCELLATION STROKE bell with slash
        /// </summary>
        public static readonly Emoji BellWithCancellationStrokeBellWithSlash = new("\U0001F515");

        /// <summary>
        /// 🎼 - MUSICAL SCORE
        /// </summary>
        public static readonly Emoji MusicalScore = new("\U0001F3BC");

        /// <summary>
        /// 🎵 - MUSICAL NOTE
        /// </summary>
        public static readonly Emoji MusicalNote = new("\U0001F3B5");

        /// <summary>
        /// 🎶 - MULTIPLE MUSICAL NOTES musical notes
        /// </summary>
        public static readonly Emoji MultipleMusicalNotesMusicalNotes = new("\U0001F3B6");

        /// <summary>
        /// 🎙 - STUDIO MICROPHONE
        /// </summary>
        public static readonly Emoji StudioMicrophone = new("\U0001F399");

        /// <summary>
        /// 🎚 - LEVEL SLIDER
        /// </summary>
        public static readonly Emoji LevelSlider = new("\U0001F39A");

        /// <summary>
        /// 🎛 - CONTROL KNOBS
        /// </summary>
        public static readonly Emoji ControlKnobs = new("\U0001F39B");

        /// <summary>
        /// 🎤 - MICROPHONE
        /// </summary>
        public static readonly Emoji Microphone = new("\U0001F3A4");

        /// <summary>
        /// 🎧 - HEADPHONE
        /// </summary>
        public static readonly Emoji Headphone = new("\U0001F3A7");

        /// <summary>
        /// 📻 - RADIO
        /// </summary>
        public static readonly Emoji Radio = new("\U0001F4FB");

        /// <summary>
        /// 🎷 - SAXOPHONE
        /// </summary>
        public static readonly Emoji Saxophone = new("\U0001F3B7");

        /// <summary>
        /// 🎸 - GUITAR
        /// </summary>
        public static readonly Emoji Guitar = new("\U0001F3B8");

        /// <summary>
        /// 🎹 - MUSICAL KEYBOARD
        /// </summary>
        public static readonly Emoji MusicalKeyboard = new("\U0001F3B9");

        /// <summary>
        /// 🎺 - TRUMPET
        /// </summary>
        public static readonly Emoji Trumpet = new("\U0001F3BA");

        /// <summary>
        /// 🎻 - VIOLIN
        /// </summary>
        public static readonly Emoji Violin = new("\U0001F3BB");

        /// <summary>
        /// 🥁 - DRUM WITH DRUMSTICKS
        /// </summary>
        public static readonly Emoji DrumWithDrumsticks = new("\U0001F941");

        /// <summary>
        /// 📱 - MOBILE PHONE
        /// </summary>
        public static readonly Emoji MobilePhone = new("\U0001F4F1");

        /// <summary>
        /// 📲 - MOBILE PHONE WITH RIGHTWARDS ARROW AT LEFT mobile phone with arrow
        /// </summary>
        public static readonly Emoji MobilePhoneWithRightwardsArrowAtLeftMobilePhoneWithArrow = new("\U0001F4F2");

        /// <summary>
        /// ☎ - BLACK TELEPHONE telephone
        /// </summary>
        public static readonly Emoji BlackTelephoneTelephone = new("\U0000260E");

        /// <summary>
        /// 📞 - TELEPHONE RECEIVER
        /// </summary>
        public static readonly Emoji TelephoneReceiver = new("\U0001F4DE");

        /// <summary>
        /// 📟 - PAGER
        /// </summary>
        public static readonly Emoji Pager = new("\U0001F4DF");

        /// <summary>
        /// 📠 - FAX MACHINE
        /// </summary>
        public static readonly Emoji FaxMachine = new("\U0001F4E0");

        /// <summary>
        /// 🔋 - BATTERY
        /// </summary>
        public static readonly Emoji Battery = new("\U0001F50B");

        /// <summary>
        /// 🔌 - ELECTRIC PLUG
        /// </summary>
        public static readonly Emoji ElectricPlug = new("\U0001F50C");

        /// <summary>
        /// 💻 - PERSONAL COMPUTER laptop computer
        /// </summary>
        public static readonly Emoji PersonalComputerLaptopComputer = new("\U0001F4BB");

        /// <summary>
        /// 🖥 - DESKTOP COMPUTER
        /// </summary>
        public static readonly Emoji DesktopComputer = new("\U0001F5A5");

        /// <summary>
        /// 🖨 - PRINTER
        /// </summary>
        public static readonly Emoji Printer = new("\U0001F5A8");

        /// <summary>
        /// ⌨ - KEYBOARD
        /// </summary>
        public static readonly Emoji Keyboard = new("\U00002328");

        /// <summary>
        /// 🖱 - THREE BUTTON MOUSE computer mouse
        /// </summary>
        public static readonly Emoji ThreeButtonMouseComputerMouse = new("\U0001F5B1");

        /// <summary>
        /// 🖲 - TRACKBALL
        /// </summary>
        public static readonly Emoji Trackball = new("\U0001F5B2");

        /// <summary>
        /// 💽 - MINIDISC
        /// </summary>
        public static readonly Emoji Minidisc = new("\U0001F4BD");

        /// <summary>
        /// 💾 - FLOPPY DISK
        /// </summary>
        public static readonly Emoji FloppyDisk = new("\U0001F4BE");

        /// <summary>
        /// 💿 - OPTICAL DISC
        /// </summary>
        public static readonly Emoji OpticalDisc = new("\U0001F4BF");

        /// <summary>
        /// 📀 - DVD
        /// </summary>
        public static readonly Emoji Dvd = new("\U0001F4C0");

        /// <summary>
        /// 🎥 - MOVIE CAMERA
        /// </summary>
        public static readonly Emoji MovieCamera = new("\U0001F3A5");

        /// <summary>
        /// 🎞 - FILM FRAMES
        /// </summary>
        public static readonly Emoji FilmFrames = new("\U0001F39E");

        /// <summary>
        /// 📽 - FILM PROJECTOR
        /// </summary>
        public static readonly Emoji FilmProjector = new("\U0001F4FD");

        /// <summary>
        /// 🎬 - CLAPPER BOARD
        /// </summary>
        public static readonly Emoji ClapperBoard = new("\U0001F3AC");

        /// <summary>
        /// 📺 - TELEVISION
        /// </summary>
        public static readonly Emoji Television = new("\U0001F4FA");

        /// <summary>
        /// 📷 - CAMERA
        /// </summary>
        public static readonly Emoji Camera = new("\U0001F4F7");

        /// <summary>
        /// 📸 - CAMERA WITH FLASH
        /// </summary>
        public static readonly Emoji CameraWithFlash = new("\U0001F4F8");

        /// <summary>
        /// 📹 - VIDEO CAMERA
        /// </summary>
        public static readonly Emoji VideoCamera = new("\U0001F4F9");

        /// <summary>
        /// 📼 - VIDEOCASSETTE
        /// </summary>
        public static readonly Emoji Videocassette = new("\U0001F4FC");

        /// <summary>
        /// 🔍 - LEFT-POINTING MAGNIFYING GLASS
        /// </summary>
        public static readonly Emoji LeftPointingMagnifyingGlass = new("\U0001F50D");

        /// <summary>
        /// 🔎 - RIGHT-POINTING MAGNIFYING GLASS
        /// </summary>
        public static readonly Emoji RightPointingMagnifyingGlass = new("\U0001F50E");

        /// <summary>
        /// 🔬 - MICROSCOPE
        /// </summary>
        public static readonly Emoji Microscope = new("\U0001F52C");

        /// <summary>
        /// 🔭 - TELESCOPE
        /// </summary>
        public static readonly Emoji Telescope = new("\U0001F52D");

        /// <summary>
        /// 📡 - SATELLITE ANTENNA
        /// </summary>
        public static readonly Emoji SatelliteAntenna = new("\U0001F4E1");

        /// <summary>
        /// 🕯 - CANDLE
        /// </summary>
        public static readonly Emoji Candle = new("\U0001F56F");

        /// <summary>
        /// 💡 - ELECTRIC LIGHT BULB light bulb
        /// </summary>
        public static readonly Emoji ElectricLightBulbLightBulb = new("\U0001F4A1");

        /// <summary>
        /// 🔦 - ELECTRIC TORCH flashlight
        /// </summary>
        public static readonly Emoji ElectricTorchFlashlight = new("\U0001F526");

        /// <summary>
        /// 🏮 - IZAKAYA LANTERN red paper lantern
        /// </summary>
        public static readonly Emoji IzakayaLanternRedPaperLantern = new("\U0001F3EE");

        /// <summary>
        /// 📔 - NOTEBOOK WITH DECORATIVE COVER
        /// </summary>
        public static readonly Emoji NotebookWithDecorativeCover = new("\U0001F4D4");

        /// <summary>
        /// 📕 - CLOSED BOOK
        /// </summary>
        public static readonly Emoji ClosedBook = new("\U0001F4D5");

        /// <summary>
        /// 📖 - OPEN BOOK
        /// </summary>
        public static readonly Emoji OpenBook = new("\U0001F4D6");

        /// <summary>
        /// 📗 - GREEN BOOK
        /// </summary>
        public static readonly Emoji GreenBook = new("\U0001F4D7");

        /// <summary>
        /// 📘 - BLUE BOOK
        /// </summary>
        public static readonly Emoji BlueBook = new("\U0001F4D8");

        /// <summary>
        /// 📙 - ORANGE BOOK
        /// </summary>
        public static readonly Emoji OrangeBook = new("\U0001F4D9");

        /// <summary>
        /// 📚 - BOOKS
        /// </summary>
        public static readonly Emoji Books = new("\U0001F4DA");

        /// <summary>
        /// 📓 - NOTEBOOK
        /// </summary>
        public static readonly Emoji Notebook = new("\U0001F4D3");

        /// <summary>
        /// 📒 - LEDGER
        /// </summary>
        public static readonly Emoji Ledger = new("\U0001F4D2");

        /// <summary>
        /// 📃 - PAGE WITH CURL
        /// </summary>
        public static readonly Emoji PageWithCurl = new("\U0001F4C3");

        /// <summary>
        /// 📜 - SCROLL
        /// </summary>
        public static readonly Emoji Scroll = new("\U0001F4DC");

        /// <summary>
        /// 📄 - PAGE FACING UP
        /// </summary>
        public static readonly Emoji PageFacingUp = new("\U0001F4C4");

        /// <summary>
        /// 📰 - NEWSPAPER
        /// </summary>
        public static readonly Emoji Newspaper = new("\U0001F4F0");

        /// <summary>
        /// 🗞 - ROLLED-UP NEWSPAPER
        /// </summary>
        public static readonly Emoji RolledUpNewspaper = new("\U0001F5DE");

        /// <summary>
        /// 📑 - BOOKMARK TABS
        /// </summary>
        public static readonly Emoji BookmarkTabs = new("\U0001F4D1");

        /// <summary>
        /// 🔖 - BOOKMARK
        /// </summary>
        public static readonly Emoji Bookmark = new("\U0001F516");

        /// <summary>
        /// 🏷 - LABEL
        /// </summary>
        public static readonly Emoji Label = new("\U0001F3F7");

        /// <summary>
        /// 💰 - MONEY BAG
        /// </summary>
        public static readonly Emoji MoneyBag = new("\U0001F4B0");

        /// <summary>
        /// 💴 - BANKNOTE WITH YEN SIGN yen banknote
        /// </summary>
        public static readonly Emoji BanknoteWithYenSignYenBanknote = new("\U0001F4B4");

        /// <summary>
        /// 💵 - BANKNOTE WITH DOLLAR SIGN dollar banknote
        /// </summary>
        public static readonly Emoji BanknoteWithDollarSignDollarBanknote = new("\U0001F4B5");

        /// <summary>
        /// 💶 - BANKNOTE WITH EURO SIGN euro banknote
        /// </summary>
        public static readonly Emoji BanknoteWithEuroSignEuroBanknote = new("\U0001F4B6");

        /// <summary>
        /// 💷 - BANKNOTE WITH POUND SIGN pound banknote
        /// </summary>
        public static readonly Emoji BanknoteWithPoundSignPoundBanknote = new("\U0001F4B7");

        /// <summary>
        /// 💸 - MONEY WITH WINGS
        /// </summary>
        public static readonly Emoji MoneyWithWings = new("\U0001F4B8");

        /// <summary>
        /// 💳 - CREDIT CARD
        /// </summary>
        public static readonly Emoji CreditCard = new("\U0001F4B3");

        /// <summary>
        /// 💹 - CHART WITH UPWARDS TREND AND YEN SIGN chart increasing with yen
        /// </summary>
        public static readonly Emoji ChartWithUpwardsTrendAndYenSignChartIncreasingWithYen = new("\U0001F4B9");

        /// <summary>
        /// 💱 - CURRENCY EXCHANGE
        /// </summary>
        public static readonly Emoji CurrencyExchange = new("\U0001F4B1");

        /// <summary>
        /// 💲 - HEAVY DOLLAR SIGN
        /// </summary>
        public static readonly Emoji HeavyDollarSign = new("\U0001F4B2");

        /// <summary>
        /// ✉ - ENVELOPE
        /// </summary>
        public static readonly Emoji Envelope = new("\U00002709");

        /// <summary>
        /// 📧 - E-MAIL SYMBOL e-mail
        /// </summary>
        public static readonly Emoji EMailSymbolEMail = new("\U0001F4E7");

        /// <summary>
        /// 📨 - INCOMING ENVELOPE
        /// </summary>
        public static readonly Emoji IncomingEnvelope = new("\U0001F4E8");

        /// <summary>
        /// 📩 - ENVELOPE WITH DOWNWARDS ARROW ABOVE envelope with arrow
        /// </summary>
        public static readonly Emoji EnvelopeWithDownwardsArrowAboveEnvelopeWithArrow = new("\U0001F4E9");

        /// <summary>
        /// 📤 - OUTBOX TRAY
        /// </summary>
        public static readonly Emoji OutboxTray = new("\U0001F4E4");

        /// <summary>
        /// 📥 - INBOX TRAY
        /// </summary>
        public static readonly Emoji InboxTray = new("\U0001F4E5");

        /// <summary>
        /// 📦 - PACKAGE
        /// </summary>
        public static readonly Emoji Package = new("\U0001F4E6");

        /// <summary>
        /// 📫 - CLOSED MAILBOX WITH RAISED FLAG
        /// </summary>
        public static readonly Emoji ClosedMailboxWithRaisedFlag = new("\U0001F4EB");

        /// <summary>
        /// 📪 - CLOSED MAILBOX WITH LOWERED FLAG
        /// </summary>
        public static readonly Emoji ClosedMailboxWithLoweredFlag = new("\U0001F4EA");

        /// <summary>
        /// 📬 - OPEN MAILBOX WITH RAISED FLAG
        /// </summary>
        public static readonly Emoji OpenMailboxWithRaisedFlag = new("\U0001F4EC");

        /// <summary>
        /// 📭 - OPEN MAILBOX WITH LOWERED FLAG
        /// </summary>
        public static readonly Emoji OpenMailboxWithLoweredFlag = new("\U0001F4ED");

        /// <summary>
        /// 📮 - POSTBOX
        /// </summary>
        public static readonly Emoji Postbox = new("\U0001F4EE");

        /// <summary>
        /// 🗳 - BALLOT BOX WITH BALLOT
        /// </summary>
        public static readonly Emoji BallotBoxWithBallot = new("\U0001F5F3");

        /// <summary>
        /// ✏ - PENCIL
        /// </summary>
        public static readonly Emoji Pencil = new("\U0000270F");

        /// <summary>
        /// ✒ - BLACK NIB
        /// </summary>
        public static readonly Emoji BlackNib = new("\U00002712");

        /// <summary>
        /// 🖋 - LOWER LEFT FOUNTAIN PEN fountain pen
        /// </summary>
        public static readonly Emoji LowerLeftFountainPenFountainPen = new("\U0001F58B");

        /// <summary>
        /// 🖊 - LOWER LEFT BALLPOINT PEN pen
        /// </summary>
        public static readonly Emoji LowerLeftBallpointPenPen = new("\U0001F58A");

        /// <summary>
        /// 🖌 - LOWER LEFT PAINTBRUSH paintbrush
        /// </summary>
        public static readonly Emoji LowerLeftPaintbrushPaintbrush = new("\U0001F58C");

        /// <summary>
        /// 🖍 - LOWER LEFT CRAYON crayon
        /// </summary>
        public static readonly Emoji LowerLeftCrayonCrayon = new("\U0001F58D");

        /// <summary>
        /// 📝 - MEMO
        /// </summary>
        public static readonly Emoji Memo = new("\U0001F4DD");

        /// <summary>
        /// 💼 - BRIEFCASE
        /// </summary>
        public static readonly Emoji Briefcase = new("\U0001F4BC");

        /// <summary>
        /// 📁 - FILE FOLDER
        /// </summary>
        public static readonly Emoji FileFolder = new("\U0001F4C1");

        /// <summary>
        /// 📂 - OPEN FILE FOLDER
        /// </summary>
        public static readonly Emoji OpenFileFolder = new("\U0001F4C2");

        /// <summary>
        /// 🗂 - CARD INDEX DIVIDERS
        /// </summary>
        public static readonly Emoji CardIndexDividers = new("\U0001F5C2");

        /// <summary>
        /// 📅 - CALENDAR
        /// </summary>
        public static readonly Emoji Calendar = new("\U0001F4C5");

        /// <summary>
        /// 📆 - TEAR-OFF CALENDAR
        /// </summary>
        public static readonly Emoji TearOffCalendar = new("\U0001F4C6");

        /// <summary>
        /// 🗒 - SPIRAL NOTE PAD spiral notepad
        /// </summary>
        public static readonly Emoji SpiralNotePadSpiralNotepad = new("\U0001F5D2");

        /// <summary>
        /// 🗓 - SPIRAL CALENDAR PAD spiral calendar
        /// </summary>
        public static readonly Emoji SpiralCalendarPadSpiralCalendar = new("\U0001F5D3");

        /// <summary>
        /// 📇 - CARD INDEX
        /// </summary>
        public static readonly Emoji CardIndex = new("\U0001F4C7");

        /// <summary>
        /// 📈 - CHART WITH UPWARDS TREND chart increasing
        /// </summary>
        public static readonly Emoji ChartWithUpwardsTrendChartIncreasing = new("\U0001F4C8");

        /// <summary>
        /// 📉 - CHART WITH DOWNWARDS TREND chart decreasing
        /// </summary>
        public static readonly Emoji ChartWithDownwardsTrendChartDecreasing = new("\U0001F4C9");

        /// <summary>
        /// 📊 - BAR CHART
        /// </summary>
        public static readonly Emoji BarChart = new("\U0001F4CA");

        /// <summary>
        /// 📋 - CLIPBOARD
        /// </summary>
        public static readonly Emoji Clipboard = new("\U0001F4CB");

        /// <summary>
        /// 📌 - PUSHPIN
        /// </summary>
        public static readonly Emoji Pushpin = new("\U0001F4CC");

        /// <summary>
        /// 📍 - ROUND PUSHPIN
        /// </summary>
        public static readonly Emoji RoundPushpin = new("\U0001F4CD");

        /// <summary>
        /// 📎 - PAPERCLIP
        /// </summary>
        public static readonly Emoji Paperclip = new("\U0001F4CE");

        /// <summary>
        /// 🖇 - LINKED PAPERCLIPS
        /// </summary>
        public static readonly Emoji LinkedPaperclips = new("\U0001F587");

        /// <summary>
        /// 📏 - STRAIGHT RULER
        /// </summary>
        public static readonly Emoji StraightRuler = new("\U0001F4CF");

        /// <summary>
        /// 📐 - TRIANGULAR RULER
        /// </summary>
        public static readonly Emoji TriangularRuler = new("\U0001F4D0");

        /// <summary>
        /// ✂ - BLACK SCISSORS scissors
        /// </summary>
        public static readonly Emoji BlackScissorsScissors = new("\U00002702");

        /// <summary>
        /// 🗃 - CARD FILE BOX
        /// </summary>
        public static readonly Emoji CardFileBox = new("\U0001F5C3");

        /// <summary>
        /// 🗄 - FILE CABINET
        /// </summary>
        public static readonly Emoji FileCabinet = new("\U0001F5C4");

        /// <summary>
        /// 🗑 - WASTEBASKET
        /// </summary>
        public static readonly Emoji Wastebasket = new("\U0001F5D1");

        /// <summary>
        /// 🔒 - LOCK
        /// </summary>
        public static readonly Emoji Lock = new("\U0001F512");

        /// <summary>
        /// 🔓 - OPEN LOCK
        /// </summary>
        public static readonly Emoji OpenLock = new("\U0001F513");

        /// <summary>
        /// 🔏 - LOCK WITH INK PEN lock with pen
        /// </summary>
        public static readonly Emoji LockWithInkPenLockWithPen = new("\U0001F50F");

        /// <summary>
        /// 🔐 - CLOSED LOCK WITH KEY
        /// </summary>
        public static readonly Emoji ClosedLockWithKey = new("\U0001F510");

        /// <summary>
        /// 🔑 - KEY
        /// </summary>
        public static readonly Emoji Key = new("\U0001F511");

        /// <summary>
        /// 🗝 - OLD KEY
        /// </summary>
        public static readonly Emoji OldKey = new("\U0001F5DD");

        /// <summary>
        /// 🔨 - HAMMER
        /// </summary>
        public static readonly Emoji Hammer = new("\U0001F528");

        /// <summary>
        /// ⛏ - PICK
        /// </summary>
        public static readonly Emoji Pick = new("\U000026CF");

        /// <summary>
        /// ⚒ - HAMMER AND PICK
        /// </summary>
        public static readonly Emoji HammerAndPick = new("\U00002692");

        /// <summary>
        /// 🛠 - HAMMER AND WRENCH
        /// </summary>
        public static readonly Emoji HammerAndWrench = new("\U0001F6E0");

        /// <summary>
        /// 🗡 - DAGGER KNIFE dagger
        /// </summary>
        public static readonly Emoji DaggerKnifeDagger = new("\U0001F5E1");

        /// <summary>
        /// ⚔ - CROSSED SWORDS
        /// </summary>
        public static readonly Emoji CrossedSwords = new("\U00002694");

        /// <summary>
        /// 🔫 - PISTOL
        /// </summary>
        public static readonly Emoji Pistol = new("\U0001F52B");

        /// <summary>
        /// 🏹 - BOW AND ARROW
        /// </summary>
        public static readonly Emoji BowAndArrow = new("\U0001F3F9");

        /// <summary>
        /// 🛡 - SHIELD
        /// </summary>
        public static readonly Emoji Shield = new("\U0001F6E1");

        /// <summary>
        /// 🔧 - WRENCH
        /// </summary>
        public static readonly Emoji Wrench = new("\U0001F527");

        /// <summary>
        /// 🔩 - NUT AND BOLT
        /// </summary>
        public static readonly Emoji NutAndBolt = new("\U0001F529");

        /// <summary>
        /// ⚙ - GEAR
        /// </summary>
        public static readonly Emoji Gear = new("\U00002699");

        /// <summary>
        /// 🗜 - COMPRESSION
        /// </summary>
        public static readonly Emoji Compression = new("\U0001F5DC");

        /// <summary>
        /// ⚗ - ALEMBIC
        /// </summary>
        public static readonly Emoji Alembic = new("\U00002697");

        /// <summary>
        /// ⚖ - SCALES balance scale
        /// </summary>
        public static readonly Emoji ScalesBalanceScale = new("\U00002696");

        /// <summary>
        /// 🔗 - LINK SYMBOL link
        /// </summary>
        public static readonly Emoji LinkSymbolLink = new("\U0001F517");

        /// <summary>
        /// ⛓ - CHAINS
        /// </summary>
        public static readonly Emoji Chains = new("\U000026D3");

        /// <summary>
        /// 💉 - SYRINGE
        /// </summary>
        public static readonly Emoji Syringe = new("\U0001F489");

        /// <summary>
        /// 💊 - PILL
        /// </summary>
        public static readonly Emoji Pill = new("\U0001F48A");

        /// <summary>
        /// 🚬 - SMOKING SYMBOL smoking
        /// </summary>
        public static readonly Emoji SmokingSymbolSmoking = new("\U0001F6AC");

        /// <summary>
        /// ⚰ - COFFIN
        /// </summary>
        public static readonly Emoji Coffin = new("\U000026B0");

        /// <summary>
        /// ⚱ - FUNERAL URN
        /// </summary>
        public static readonly Emoji FuneralUrn = new("\U000026B1");

        /// <summary>
        /// 🗿 - MOYAI moai
        /// </summary>
        public static readonly Emoji MoyaiMoai = new("\U0001F5FF");

        /// <summary>
        /// 🛢 - OIL DRUM
        /// </summary>
        public static readonly Emoji OilDrum = new("\U0001F6E2");

        /// <summary>
        /// 🔮 - CRYSTAL BALL
        /// </summary>
        public static readonly Emoji CrystalBall = new("\U0001F52E");

        /// <summary>
        /// 🛒 - SHOPPING TROLLEY
        /// </summary>
        public static readonly Emoji ShoppingTrolley = new("\U0001F6D2");
    }

    /// <summary>
    /// Symbols
    /// </summary>
    public static class Symbols
    {
        /// <summary>
        /// 🏧 - AUTOMATED TELLER MACHINE ATM sign
        /// </summary>
        public static readonly Emoji AutomatedTellerMachineAtmSign = new("\U0001F3E7");

        /// <summary>
        /// 🚮 - PUT LITTER IN ITS PLACE SYMBOL litter in bin sign
        /// </summary>
        public static readonly Emoji PutLitterInItsPlaceSymbolLitterInBinSign = new("\U0001F6AE");

        /// <summary>
        /// 🚰 - POTABLE WATER SYMBOL potable water
        /// </summary>
        public static readonly Emoji PotableWaterSymbolPotableWater = new("\U0001F6B0");

        /// <summary>
        /// ♿ - WHEELCHAIR SYMBOL wheelchair
        /// </summary>
        public static readonly Emoji WheelchairSymbolWheelchair = new("\U0000267F");

        /// <summary>
        /// 🚹 - MENS SYMBOL mens room
        /// </summary>
        public static readonly Emoji MensSymbolMensRoom = new("\U0001F6B9");

        /// <summary>
        /// 🚺 - WOMENS SYMBOL womens room
        /// </summary>
        public static readonly Emoji WomensSymbolWomensRoom = new("\U0001F6BA");

        /// <summary>
        /// 🚻 - RESTROOM
        /// </summary>
        public static readonly Emoji Restroom = new("\U0001F6BB");

        /// <summary>
        /// 🚼 - BABY SYMBOL
        /// </summary>
        public static readonly Emoji BabySymbol = new("\U0001F6BC");

        /// <summary>
        /// 🚾 - WATER CLOSET
        /// </summary>
        public static readonly Emoji WaterCloset = new("\U0001F6BE");

        /// <summary>
        /// 🛂 - PASSPORT CONTROL
        /// </summary>
        public static readonly Emoji PassportControl = new("\U0001F6C2");

        /// <summary>
        /// 🛃 - CUSTOMS
        /// </summary>
        public static readonly Emoji Customs = new("\U0001F6C3");

        /// <summary>
        /// 🛄 - BAGGAGE CLAIM
        /// </summary>
        public static readonly Emoji BaggageClaim = new("\U0001F6C4");

        /// <summary>
        /// 🛅 - LEFT LUGGAGE
        /// </summary>
        public static readonly Emoji LeftLuggage = new("\U0001F6C5");

        /// <summary>
        /// ⚠ - WARNING SIGN warning
        /// </summary>
        public static readonly Emoji WarningSignWarning = new("\U000026A0");

        /// <summary>
        /// 🚸 - CHILDREN CROSSING
        /// </summary>
        public static readonly Emoji ChildrenCrossing = new("\U0001F6B8");

        /// <summary>
        /// ⛔ - NO ENTRY
        /// </summary>
        public static readonly Emoji NoEntry = new("\U000026D4");

        /// <summary>
        /// 🚫 - NO ENTRY SIGN prohibited
        /// </summary>
        public static readonly Emoji NoEntrySignProhibited = new("\U0001F6AB");

        /// <summary>
        /// 🚳 - NO BICYCLES
        /// </summary>
        public static readonly Emoji NoBicycles = new("\U0001F6B3");

        /// <summary>
        /// 🚭 - NO SMOKING SYMBOL no smoking
        /// </summary>
        public static readonly Emoji NoSmokingSymbolNoSmoking = new("\U0001F6AD");

        /// <summary>
        /// 🚯 - DO NOT LITTER SYMBOL no littering
        /// </summary>
        public static readonly Emoji DoNotLitterSymbolNoLittering = new("\U0001F6AF");

        /// <summary>
        /// 🚱 - NON-POTABLE WATER SYMBOL non-potable water
        /// </summary>
        public static readonly Emoji NonPotableWaterSymbolNonPotableWater = new("\U0001F6B1");

        /// <summary>
        /// 🚷 - NO PEDESTRIANS
        /// </summary>
        public static readonly Emoji NoPedestrians = new("\U0001F6B7");

        /// <summary>
        /// 📵 - NO MOBILE PHONES
        /// </summary>
        public static readonly Emoji NoMobilePhones = new("\U0001F4F5");

        /// <summary>
        /// 🔞 - NO ONE UNDER EIGHTEEN SYMBOL no one under eighteen
        /// </summary>
        public static readonly Emoji NoOneUnderEighteenSymbolNoOneUnderEighteen = new("\U0001F51E");

        /// <summary>
        /// ☢ - RADIOACTIVE SIGN radioactive
        /// </summary>
        public static readonly Emoji RadioactiveSignRadioactive = new("\U00002622");

        /// <summary>
        /// ☣ - BIOHAZARD SIGN biohazard
        /// </summary>
        public static readonly Emoji BiohazardSignBiohazard = new("\U00002623");

        /// <summary>
        /// ⬆ - UPWARDS BLACK ARROW up arrow
        /// </summary>
        public static readonly Emoji UpwardsBlackArrowUpArrow = new("\U00002B06");

        /// <summary>
        /// ↗ - NORTH EAST ARROW up-right arrow
        /// </summary>
        public static readonly Emoji NorthEastArrowUpRightArrow = new("\U00002197");

        /// <summary>
        /// ➡ - BLACK RIGHTWARDS ARROW right arrow
        /// </summary>
        public static readonly Emoji BlackRightwardsArrowRightArrow = new("\U000027A1");

        /// <summary>
        /// ↘ - SOUTH EAST ARROW down-right arrow
        /// </summary>
        public static readonly Emoji SouthEastArrowDownRightArrow = new("\U00002198");

        /// <summary>
        /// ⬇ - DOWNWARDS BLACK ARROW down arrow
        /// </summary>
        public static readonly Emoji DownwardsBlackArrowDownArrow = new("\U00002B07");

        /// <summary>
        /// ↙ - SOUTH WEST ARROW down-left arrow
        /// </summary>
        public static readonly Emoji SouthWestArrowDownLeftArrow = new("\U00002199");

        /// <summary>
        /// ⬅ - LEFTWARDS BLACK ARROW left arrow
        /// </summary>
        public static readonly Emoji LeftwardsBlackArrowLeftArrow = new("\U00002B05");

        /// <summary>
        /// ↖ - NORTH WEST ARROW up-left arrow
        /// </summary>
        public static readonly Emoji NorthWestArrowUpLeftArrow = new("\U00002196");

        /// <summary>
        /// ↕ - UP DOWN ARROW up-down arrow
        /// </summary>
        public static readonly Emoji UpDownArrowUpDownArrow = new("\U00002195");

        /// <summary>
        /// ↔ - LEFT RIGHT ARROW left-right arrow
        /// </summary>
        public static readonly Emoji LeftRightArrowLeftRightArrow = new("\U00002194");

        /// <summary>
        /// ↩ - LEFTWARDS ARROW WITH HOOK right arrow curving left
        /// </summary>
        public static readonly Emoji LeftwardsArrowWithHookRightArrowCurvingLeft = new("\U000021A9");

        /// <summary>
        /// ↪ - RIGHTWARDS ARROW WITH HOOK left arrow curving right
        /// </summary>
        public static readonly Emoji RightwardsArrowWithHookLeftArrowCurvingRight = new("\U000021AA");

        /// <summary>
        /// ⤴ - ARROW POINTING RIGHTWARDS THEN CURVING UPWARDS right arrow curving up
        /// </summary>
        public static readonly Emoji ArrowPointingRightwardsThenCurvingUpwardsRightArrowCurvingUp = new("\U00002934");

        /// <summary>
        /// ⤵ - ARROW POINTING RIGHTWARDS THEN CURVING DOWNWARDS right arrow curving down
        /// </summary>
        public static readonly Emoji ArrowPointingRightwardsThenCurvingDownwardsRightArrowCurvingDown = new("\U00002935");

        /// <summary>
        /// 🔃 - CLOCKWISE DOWNWARDS AND UPWARDS OPEN CIRCLE ARROWS clockwise vertical arrows
        /// </summary>
        public static readonly Emoji ClockwiseDownwardsAndUpwardsOpenCircleArrowsClockwiseVerticalArrows = new("\U0001F503");

        /// <summary>
        /// 🔄 - ANTICLOCKWISE DOWNWARDS AND UPWARDS OPEN CIRCLE ARROWS anticlockwise arrows button
        /// </summary>
        public static readonly Emoji AnticlockwiseDownwardsAndUpwardsOpenCircleArrowsAnticlockwiseArrowsButton = new("\U0001F504");

        /// <summary>
        /// 🔙 - BACK WITH LEFTWARDS ARROW ABOVE back arrow
        /// </summary>
        public static readonly Emoji BackWithLeftwardsArrowAboveBackArrow = new("\U0001F519");

        /// <summary>
        /// 🔚 - END WITH LEFTWARDS ARROW ABOVE end arrow
        /// </summary>
        public static readonly Emoji EndWithLeftwardsArrowAboveEndArrow = new("\U0001F51A");

        /// <summary>
        /// 🔛 - ON WITH EXCLAMATION MARK WITH LEFT RIGHT ARROW ABOVE on arrow
        /// </summary>
        public static readonly Emoji OnWithExclamationMarkWithLeftRightArrowAboveOnArrow = new("\U0001F51B");

        /// <summary>
        /// 🔜 - SOON WITH RIGHTWARDS ARROW ABOVE soon arrow
        /// </summary>
        public static readonly Emoji SoonWithRightwardsArrowAboveSoonArrow = new("\U0001F51C");

        /// <summary>
        /// 🔝 - TOP WITH UPWARDS ARROW ABOVE top arrow
        /// </summary>
        public static readonly Emoji TopWithUpwardsArrowAboveTopArrow = new("\U0001F51D");

        /// <summary>
        /// 🛐 - PLACE OF WORSHIP
        /// </summary>
        public static readonly Emoji PlaceOfWorship = new("\U0001F6D0");

        /// <summary>
        /// ⚛ - ATOM SYMBOL
        /// </summary>
        public static readonly Emoji AtomSymbol = new("\U0000269B");

        /// <summary>
        /// 🕉 - OM SYMBOL om
        /// </summary>
        public static readonly Emoji OmSymbolOm = new("\U0001F549");

        /// <summary>
        /// ✡ - STAR OF DAVID
        /// </summary>
        public static readonly Emoji StarOfDavid = new("\U00002721");

        /// <summary>
        /// ☸ - WHEEL OF DHARMA
        /// </summary>
        public static readonly Emoji WheelOfDharma = new("\U00002638");

        /// <summary>
        /// ☯ - YIN YANG
        /// </summary>
        public static readonly Emoji YinYang = new("\U0000262F");

        /// <summary>
        /// ✝ - LATIN CROSS
        /// </summary>
        public static readonly Emoji LatinCross = new("\U0000271D");

        /// <summary>
        /// ☦ - ORTHODOX CROSS
        /// </summary>
        public static readonly Emoji OrthodoxCross = new("\U00002626");

        /// <summary>
        /// ☪ - STAR AND CRESCENT
        /// </summary>
        public static readonly Emoji StarAndCrescent = new("\U0000262A");

        /// <summary>
        /// ☮ - PEACE SYMBOL
        /// </summary>
        public static readonly Emoji PeaceSymbol = new("\U0000262E");

        /// <summary>
        /// 🕎 - MENORAH WITH NINE BRANCHES menorah
        /// </summary>
        public static readonly Emoji MenorahWithNineBranchesMenorah = new("\U0001F54E");

        /// <summary>
        /// 🔯 - SIX POINTED STAR WITH MIDDLE DOT dotted six-pointed star
        /// </summary>
        public static readonly Emoji SixPointedStarWithMiddleDotDottedSixPointedStar = new("\U0001F52F");

        /// <summary>
        /// ♻ - BLACK UNIVERSAL RECYCLING SYMBOL recycling symbol
        /// </summary>
        public static readonly Emoji BlackUniversalRecyclingSymbolRecyclingSymbol = new("\U0000267B");

        /// <summary>
        /// 📛 - NAME BADGE
        /// </summary>
        public static readonly Emoji NameBadge = new("\U0001F4DB");

        /// <summary>
        /// ⚜ - FLEUR-DE-LIS
        /// </summary>
        public static readonly Emoji FleurDeLis = new("\U0000269C");

        /// <summary>
        /// 🔰 - JAPANESE SYMBOL FOR BEGINNER
        /// </summary>
        public static readonly Emoji JapaneseSymbolForBeginner = new("\U0001F530");

        /// <summary>
        /// 🔱 - TRIDENT EMBLEM
        /// </summary>
        public static readonly Emoji TridentEmblem = new("\U0001F531");

        /// <summary>
        /// ⭕ - HEAVY LARGE CIRCLE
        /// </summary>
        public static readonly Emoji HeavyLargeCircle = new("\U00002B55");

        /// <summary>
        /// ✅ - WHITE HEAVY CHECK MARK
        /// </summary>
        public static readonly Emoji WhiteHeavyCheckMark = new("\U00002705");

        /// <summary>
        /// ☑ - BALLOT BOX WITH CHECK
        /// </summary>
        public static readonly Emoji BallotBoxWithCheck = new("\U00002611");

        /// <summary>
        /// ✔ - HEAVY CHECK MARK
        /// </summary>
        public static readonly Emoji HeavyCheckMark = new("\U00002714");

        /// <summary>
        /// ✖ - HEAVY MULTIPLICATION X
        /// </summary>
        public static readonly Emoji HeavyMultiplicationX = new("\U00002716");

        /// <summary>
        /// ❌ - CROSS MARK
        /// </summary>
        public static readonly Emoji CrossMark = new("\U0000274C");

        /// <summary>
        /// ❎ - NEGATIVE SQUARED CROSS MARK cross mark button
        /// </summary>
        public static readonly Emoji NegativeSquaredCrossMarkCrossMarkButton = new("\U0000274E");

        /// <summary>
        /// ➕ - HEAVY PLUS SIGN
        /// </summary>
        public static readonly Emoji HeavyPlusSign = new("\U00002795");

        /// <summary>
        /// ➖ - HEAVY MINUS SIGN
        /// </summary>
        public static readonly Emoji HeavyMinusSign = new("\U00002796");

        /// <summary>
        /// ➗ - HEAVY DIVISION SIGN
        /// </summary>
        public static readonly Emoji HeavyDivisionSign = new("\U00002797");

        /// <summary>
        /// ➰ - CURLY LOOP
        /// </summary>
        public static readonly Emoji CurlyLoop = new("\U000027B0");

        /// <summary>
        /// ➿ - DOUBLE CURLY LOOP
        /// </summary>
        public static readonly Emoji DoubleCurlyLoop = new("\U000027BF");

        /// <summary>
        /// 〽 - PART ALTERNATION MARK
        /// </summary>
        public static readonly Emoji PartAlternationMark = new("\U0000303D");

        /// <summary>
        /// ✳ - EIGHT SPOKED ASTERISK eight-spoked asterisk
        /// </summary>
        public static readonly Emoji EightSpokedAsteriskEightSpokedAsterisk = new("\U00002733");

        /// <summary>
        /// ✴ - EIGHT POINTED BLACK STAR eight-pointed star
        /// </summary>
        public static readonly Emoji EightPointedBlackStarEightPointedStar = new("\U00002734");

        /// <summary>
        /// ❇ - SPARKLE
        /// </summary>
        public static readonly Emoji Sparkle = new("\U00002747");

        /// <summary>
        /// ‼ - DOUBLE EXCLAMATION MARK
        /// </summary>
        public static readonly Emoji DoubleExclamationMark = new("\U0000203C");

        /// <summary>
        /// ⁉ - EXCLAMATION QUESTION MARK
        /// </summary>
        public static readonly Emoji ExclamationQuestionMark = new("\U00002049");

        /// <summary>
        /// ❓ - BLACK QUESTION MARK ORNAMENT question mark
        /// </summary>
        public static readonly Emoji BlackQuestionMarkOrnamentQuestionMark = new("\U00002753");

        /// <summary>
        /// ❔ - WHITE QUESTION MARK ORNAMENT white question mark
        /// </summary>
        public static readonly Emoji WhiteQuestionMarkOrnamentWhiteQuestionMark = new("\U00002754");

        /// <summary>
        /// ❕ - WHITE EXCLAMATION MARK ORNAMENT white exclamation mark
        /// </summary>
        public static readonly Emoji WhiteExclamationMarkOrnamentWhiteExclamationMark = new("\U00002755");

        /// <summary>
        /// ❗ - HEAVY EXCLAMATION MARK SYMBOL exclamation mark
        /// </summary>
        public static readonly Emoji HeavyExclamationMarkSymbolExclamationMark = new("\U00002757");

        /// <summary>
        /// 〰 - WAVY DASH
        /// </summary>
        public static readonly Emoji WavyDash = new("\U00003030");

        /// <summary>
        /// © - COPYRIGHT SIGN copyright
        /// </summary>
        public static readonly Emoji CopyrightSignCopyright = new("\U000000A9");

        /// <summary>
        /// ® - REGISTERED SIGN registered
        /// </summary>
        public static readonly Emoji RegisteredSignRegistered = new("\U000000AE");

        /// <summary>
        /// ™ - TRADE MARK SIGN trade mark
        /// </summary>
        public static readonly Emoji TradeMarkSignTradeMark = new("\U00002122");

        /// <summary>
        /// ♈ - ARIES
        /// </summary>
        public static readonly Emoji Aries = new("\U00002648");

        /// <summary>
        /// ♉ - TAURUS
        /// </summary>
        public static readonly Emoji Taurus = new("\U00002649");

        /// <summary>
        /// ♊ - GEMINI
        /// </summary>
        public static readonly Emoji Gemini = new("\U0000264A");

        /// <summary>
        /// ♋ - CANCER
        /// </summary>
        public static readonly Emoji Cancer = new("\U0000264B");

        /// <summary>
        /// ♌ - LEO
        /// </summary>
        public static readonly Emoji Leo = new("\U0000264C");

        /// <summary>
        /// ♍ - VIRGO
        /// </summary>
        public static readonly Emoji Virgo = new("\U0000264D");

        /// <summary>
        /// ♎ - LIBRA
        /// </summary>
        public static readonly Emoji Libra = new("\U0000264E");

        /// <summary>
        /// ♏ - SCORPIUS
        /// </summary>
        public static readonly Emoji Scorpius = new("\U0000264F");

        /// <summary>
        /// ♐ - SAGITTARIUS
        /// </summary>
        public static readonly Emoji Sagittarius = new("\U00002650");

        /// <summary>
        /// ♑ - CAPRICORN
        /// </summary>
        public static readonly Emoji Capricorn = new("\U00002651");

        /// <summary>
        /// ♒ - AQUARIUS
        /// </summary>
        public static readonly Emoji Aquarius = new("\U00002652");

        /// <summary>
        /// ♓ - PISCES
        /// </summary>
        public static readonly Emoji Pisces = new("\U00002653");

        /// <summary>
        /// ⛎ - OPHIUCHUS
        /// </summary>
        public static readonly Emoji Ophiuchus = new("\U000026CE");

        /// <summary>
        /// 🔀 - TWISTED RIGHTWARDS ARROWS shuffle tracks button
        /// </summary>
        public static readonly Emoji TwistedRightwardsArrowsShuffleTracksButton = new("\U0001F500");

        /// <summary>
        /// 🔁 - CLOCKWISE RIGHTWARDS AND LEFTWARDS OPEN CIRCLE ARROWS repeat button
        /// </summary>
        public static readonly Emoji ClockwiseRightwardsAndLeftwardsOpenCircleArrowsRepeatButton = new("\U0001F501");

        /// <summary>
        /// 🔂 - CLOCKWISE RIGHTWARDS AND LEFTWARDS OPEN CIRCLE ARROWS WITH CIRCLED ONE OVERLAY repeat single button
        /// </summary>
        public static readonly Emoji ClockwiseRightwardsAndLeftwardsOpenCircleArrowsWithCircledOneOverlayRepeatSingleButton = new("\U0001F502");

        /// <summary>
        /// ▶ - BLACK RIGHT-POINTING TRIANGLE play button
        /// </summary>
        public static readonly Emoji BlackRightPointingTrianglePlayButton = new("\U000025B6");

        /// <summary>
        /// ⏩ - BLACK RIGHT-POINTING DOUBLE TRIANGLE fast-forword button
        /// </summary>
        public static readonly Emoji BlackRightPointingDoubleTriangleFastForwordButton = new("\U000023E9");

        /// <summary>
        /// ⏭ - BLACK RIGHT-POINTING DOUBLE TRIANGLE WITH VERTICAL BAR next track button
        /// </summary>
        public static readonly Emoji BlackRightPointingDoubleTriangleWithVerticalBarNextTrackButton = new("\U000023ED");

        /// <summary>
        /// ⏯ - BLACK RIGHT-POINTING TRIANGLE WITH DOUBLE VERTICAL BAR play or pause button
        /// </summary>
        public static readonly Emoji BlackRightPointingTriangleWithDoubleVerticalBarPlayOrPauseButton = new("\U000023EF");

        /// <summary>
        /// ◀ - BLACK LEFT-POINTING TRIANGLE reverse button
        /// </summary>
        public static readonly Emoji BlackLeftPointingTriangleReverseButton = new("\U000025C0");

        /// <summary>
        /// ⏪ - BLACK LEFT-POINTING DOUBLE TRIANGLE fast reverse button
        /// </summary>
        public static readonly Emoji BlackLeftPointingDoubleTriangleFastReverseButton = new("\U000023EA");

        /// <summary>
        /// ⏮ - BLACK LEFT-POINTING DOUBLE TRIANGLE WITH VERTICAL BAR last track button
        /// </summary>
        public static readonly Emoji BlackLeftPointingDoubleTriangleWithVerticalBarLastTrackButton = new("\U000023EE");

        /// <summary>
        /// 🔼 - UP-POINTING SMALL RED TRIANGLE up button
        /// </summary>
        public static readonly Emoji UpPointingSmallRedTriangleUpButton = new("\U0001F53C");

        /// <summary>
        /// ⏫ - BLACK UP-POINTING DOUBLE TRIANGLE fast up button
        /// </summary>
        public static readonly Emoji BlackUpPointingDoubleTriangleFastUpButton = new("\U000023EB");

        /// <summary>
        /// 🔽 - DOWN-POINTING SMALL RED TRIANGLE down button
        /// </summary>
        public static readonly Emoji DownPointingSmallRedTriangleDownButton = new("\U0001F53D");

        /// <summary>
        /// ⏬ - BLACK DOWN-POINTING DOUBLE TRIANGLE fast down button
        /// </summary>
        public static readonly Emoji BlackDownPointingDoubleTriangleFastDownButton = new("\U000023EC");

        /// <summary>
        /// ⏸ - DOUBLE VERTICAL BAR pause button
        /// </summary>
        public static readonly Emoji DoubleVerticalBarPauseButton = new("\U000023F8");

        /// <summary>
        /// ⏹ - BLACK SQUARE FOR STOP stop button
        /// </summary>
        public static readonly Emoji BlackSquareForStopStopButton = new("\U000023F9");

        /// <summary>
        /// ⏺ - BLACK CIRCLE FOR RECORD record button
        /// </summary>
        public static readonly Emoji BlackCircleForRecordRecordButton = new("\U000023FA");

        /// <summary>
        /// ⏏ - EJECT SYMBOL eject button
        /// </summary>
        public static readonly Emoji EjectSymbolEjectButton = new("\U000023CF");

        /// <summary>
        /// 🎦 - CINEMA
        /// </summary>
        public static readonly Emoji Cinema = new("\U0001F3A6");

        /// <summary>
        /// 🔅 - LOW BRIGHTNESS SYMBOL dim button
        /// </summary>
        public static readonly Emoji LowBrightnessSymbolDimButton = new("\U0001F505");

        /// <summary>
        /// 🔆 - HIGH BRIGHTNESS SYMBOL bright button
        /// </summary>
        public static readonly Emoji HighBrightnessSymbolBrightButton = new("\U0001F506");

        /// <summary>
        /// 📶 - ANTENNA WITH BARS antenna bars
        /// </summary>
        public static readonly Emoji AntennaWithBarsAntennaBars = new("\U0001F4F6");

        /// <summary>
        /// 📳 - VIBRATION MODE
        /// </summary>
        public static readonly Emoji VibrationMode = new("\U0001F4F3");

        /// <summary>
        /// 📴 - MOBILE PHONE OFF
        /// </summary>
        public static readonly Emoji MobilePhoneOff = new("\U0001F4F4");

        /// <summary>
        /// #️⃣ - Keycap NUMBER SIGN
        /// </summary>
        public static readonly Emoji KeycapNumberSign = new("\U00000023\U0000FE0F");

        /// <summary>
        /// *️⃣ - Keycap ASTERISK
        /// </summary>
        public static readonly Emoji KeycapAsterisk = new("\U0000002A\U0000FE0F");

        /// <summary>
        /// 0️⃣ - Keycap DIGIT ZERO
        /// </summary>
        public static readonly Emoji KeycapDigitZero = new("\U00000030\U0000FE0F");

        /// <summary>
        /// 1️⃣ - Keycap DIGIT ONE
        /// </summary>
        public static readonly Emoji KeycapDigitOne = new("\U00000031\U0000FE0F");

        /// <summary>
        /// 2️⃣ - Keycap DIGIT TWO
        /// </summary>
        public static readonly Emoji KeycapDigitTwo = new("\U00000032\U0000FE0F");

        /// <summary>
        /// 3️⃣ - Keycap DIGIT THREE
        /// </summary>
        public static readonly Emoji KeycapDigitThree = new("\U00000033\U0000FE0F");

        /// <summary>
        /// 4️⃣ - Keycap DIGIT FOUR
        /// </summary>
        public static readonly Emoji KeycapDigitFour = new("\U00000034\U0000FE0F");

        /// <summary>
        /// 5️⃣ - Keycap DIGIT FIVE
        /// </summary>
        public static readonly Emoji KeycapDigitFive = new("\U00000035\U0000FE0F");

        /// <summary>
        /// 6️⃣ - Keycap DIGIT SIX
        /// </summary>
        public static readonly Emoji KeycapDigitSix = new("\U00000036\U0000FE0F");

        /// <summary>
        /// 7️⃣ - Keycap DIGIT SEVEN
        /// </summary>
        public static readonly Emoji KeycapDigitSeven = new("\U00000037\U0000FE0F");

        /// <summary>
        /// 8️⃣ - Keycap DIGIT EIGHT
        /// </summary>
        public static readonly Emoji KeycapDigitEight = new("\U00000038\U0000FE0F");

        /// <summary>
        /// 9️⃣ - Keycap DIGIT NINE
        /// </summary>
        public static readonly Emoji KeycapDigitNine = new("\U00000039\U0000FE0F");

        /// <summary>
        /// 🔟 - KEYCAP TEN
        /// </summary>
        public static readonly Emoji KeycapTen = new("\U0001F51F");

        /// <summary>
        /// 💯 - HUNDRED POINTS SYMBOL hundred points
        /// </summary>
        public static readonly Emoji HundredPointsSymbolHundredPoints = new("\U0001F4AF");

        /// <summary>
        /// 🔠 - INPUT SYMBOL FOR LATIN CAPITAL LETTERS input latin uppercase
        /// </summary>
        public static readonly Emoji InputSymbolForLatinCapitalLettersInputLatinUppercase = new("\U0001F520");

        /// <summary>
        /// 🔡 - INPUT SYMBOL FOR LATIN SMALL LETTERS input latin lowercase
        /// </summary>
        public static readonly Emoji InputSymbolForLatinSmallLettersInputLatinLowercase = new("\U0001F521");

        /// <summary>
        /// 🔢 - INPUT SYMBOL FOR NUMBERS input numbers
        /// </summary>
        public static readonly Emoji InputSymbolForNumbersInputNumbers = new("\U0001F522");

        /// <summary>
        /// 🔣 - INPUT SYMBOL FOR SYMBOLS input symbols
        /// </summary>
        public static readonly Emoji InputSymbolForSymbolsInputSymbols = new("\U0001F523");

        /// <summary>
        /// 🔤 - INPUT SYMBOL FOR LATIN LETTERS input latin letters
        /// </summary>
        public static readonly Emoji InputSymbolForLatinLettersInputLatinLetters = new("\U0001F524");

        /// <summary>
        /// 🅰 - NEGATIVE SQUARED LATIN CAPITAL LETTER A a button
        /// </summary>
        public static readonly Emoji NegativeSquaredLatinCapitalLetterAAButton = new("\U0001F170");

        /// <summary>
        /// 🆎 - NEGATIVE SQUARED AB ab button
        /// </summary>
        public static readonly Emoji NegativeSquaredAbAbButton = new("\U0001F18E");

        /// <summary>
        /// 🅱 - NEGATIVE SQUARED LATIN CAPITAL LETTER B b button
        /// </summary>
        public static readonly Emoji NegativeSquaredLatinCapitalLetterBBButton = new("\U0001F171");

        /// <summary>
        /// 🆑 - SQUARED CL
        /// </summary>
        public static readonly Emoji SquaredCl = new("\U0001F191");

        /// <summary>
        /// 🆒 - SQUARED COOL
        /// </summary>
        public static readonly Emoji SquaredCool = new("\U0001F192");

        /// <summary>
        /// 🆓 - SQUARED FREE
        /// </summary>
        public static readonly Emoji SquaredFree = new("\U0001F193");

        /// <summary>
        /// ℹ - INFORMATION SOURCE
        /// </summary>
        public static readonly Emoji InformationSource = new("\U00002139");

        /// <summary>
        /// 🆔 - SQUARED ID
        /// </summary>
        public static readonly Emoji SquaredId = new("\U0001F194");

        /// <summary>
        /// Ⓜ - CIRCLED LATIN CAPITAL LETTER M circled letter m
        /// </summary>
        public static readonly Emoji CircledLatinCapitalLetterMCircledLetterM = new("\U000024C2");

        /// <summary>
        /// 🆕 - SQUARED NEW
        /// </summary>
        public static readonly Emoji SquaredNew = new("\U0001F195");

        /// <summary>
        /// 🆖 - SQUARED NG
        /// </summary>
        public static readonly Emoji SquaredNg = new("\U0001F196");

        /// <summary>
        /// 🅾 - NEGATIVE SQUARED LATIN CAPITAL LETTER O o button
        /// </summary>
        public static readonly Emoji NegativeSquaredLatinCapitalLetterOOButton = new("\U0001F17E");

        /// <summary>
        /// 🆗 - SQUARED OK
        /// </summary>
        public static readonly Emoji SquaredOk = new("\U0001F197");

        /// <summary>
        /// 🅿 - NEGATIVE SQUARED LATIN CAPITAL LETTER P p button
        /// </summary>
        public static readonly Emoji NegativeSquaredLatinCapitalLetterPPButton = new("\U0001F17F");

        /// <summary>
        /// 🆘 - SQUARED SOS
        /// </summary>
        public static readonly Emoji SquaredSos = new("\U0001F198");

        /// <summary>
        /// 🆙 - SQUARED UP WITH EXCLAMATION MARK up button
        /// </summary>
        public static readonly Emoji SquaredUpWithExclamationMarkUpButton = new("\U0001F199");

        /// <summary>
        /// 🆚 - SQUARED VS
        /// </summary>
        public static readonly Emoji SquaredVs = new("\U0001F19A");

        /// <summary>
        /// 🈁 - SQUARED KATAKANA KOKO
        /// </summary>
        public static readonly Emoji SquaredKatakanaKoko = new("\U0001F201");

        /// <summary>
        /// 🈂 - SQUARED KATAKANA SA
        /// </summary>
        public static readonly Emoji SquaredKatakanaSa = new("\U0001F202");

        /// <summary>
        /// 🈷 - SQUARED CJK UNIFIED IDEOGRAPH-6708 squared moon ideograph
        /// </summary>
        public static readonly Emoji SquaredCjkUnifiedIdeograph6708SquaredMoonIdeograph = new("\U0001F237");

        /// <summary>
        /// 🈶 - SQUARED CJK UNIFIED IDEOGRAPH-6709 squared exist ideograph
        /// </summary>
        public static readonly Emoji SquaredCjkUnifiedIdeograph6709SquaredExistIdeograph = new("\U0001F236");

        /// <summary>
        /// 🈯 - SQUARED CJK UNIFIED IDEOGRAPH-6307 squared finger ideograph
        /// </summary>
        public static readonly Emoji SquaredCjkUnifiedIdeograph6307SquaredFingerIdeograph = new("\U0001F22F");

        /// <summary>
        /// 🉐 - CIRCLED IDEOGRAPH ADVANTAGE circled advantage ideograph
        /// </summary>
        public static readonly Emoji CircledIdeographAdvantageCircledAdvantageIdeograph = new("\U0001F250");

        /// <summary>
        /// 🈹 - SQUARED CJK UNIFIED IDEOGRAPH-5272 squared divide ideograph
        /// </summary>
        public static readonly Emoji SquaredCjkUnifiedIdeograph5272SquaredDivideIdeograph = new("\U0001F239");

        /// <summary>
        /// 🈚 - SQUARED CJK UNIFIED IDEOGRAPH-7121 squared negation ideograph
        /// </summary>
        public static readonly Emoji SquaredCjkUnifiedIdeograph7121SquaredNegationIdeograph = new("\U0001F21A");

        /// <summary>
        /// 🈲 - SQUARED CJK UNIFIED IDEOGRAPH-7981 squared prohibit ideograph
        /// </summary>
        public static readonly Emoji SquaredCjkUnifiedIdeograph7981SquaredProhibitIdeograph = new("\U0001F232");

        /// <summary>
        /// 🉑 - CIRCLED IDEOGRAPH ACCEPT circled accept ideograph
        /// </summary>
        public static readonly Emoji CircledIdeographAcceptCircledAcceptIdeograph = new("\U0001F251");

        /// <summary>
        /// 🈸 - SQUARED CJK UNIFIED IDEOGRAPH-7533 squared apply ideograph
        /// </summary>
        public static readonly Emoji SquaredCjkUnifiedIdeograph7533SquaredApplyIdeograph = new("\U0001F238");

        /// <summary>
        /// 🈴 - SQUARED CJK UNIFIED IDEOGRAPH-5408 squared together ideograph
        /// </summary>
        public static readonly Emoji SquaredCjkUnifiedIdeograph5408SquaredTogetherIdeograph = new("\U0001F234");

        /// <summary>
        /// 🈳 - SQUARED CJK UNIFIED IDEOGRAPH-7A7A squared empty ideograph
        /// </summary>
        public static readonly Emoji SquaredCjkUnifiedIdeograph7a7aSquaredEmptyIdeograph = new("\U0001F233");

        /// <summary>
        /// ㊗ - CIRCLED IDEOGRAPH CONGRATULATION circled congratulate ideograph
        /// </summary>
        public static readonly Emoji CircledIdeographCongratulationCircledCongratulateIdeograph = new("\U00003297");

        /// <summary>
        /// ㊙ - CIRCLED IDEOGRAPH SECRET circled secret ideograph
        /// </summary>
        public static readonly Emoji CircledIdeographSecretCircledSecretIdeograph = new("\U00003299");

        /// <summary>
        /// 🈺 - SQUARED CJK UNIFIED IDEOGRAPH-55B6 squared operating ideograph
        /// </summary>
        public static readonly Emoji SquaredCjkUnifiedIdeograph55b6SquaredOperatingIdeograph = new("\U0001F23A");

        /// <summary>
        /// 🈵 - SQUARED CJK UNIFIED IDEOGRAPH-6E80 squared fullness ideograph
        /// </summary>
        public static readonly Emoji SquaredCjkUnifiedIdeograph6e80SquaredFullnessIdeograph = new("\U0001F235");

        /// <summary>
        /// ▪ - BLACK SMALL SQUARE
        /// </summary>
        public static readonly Emoji BlackSmallSquare = new("\U000025AA");

        /// <summary>
        /// ▫ - WHITE SMALL SQUARE
        /// </summary>
        public static readonly Emoji WhiteSmallSquare = new("\U000025AB");

        /// <summary>
        /// ◻ - WHITE MEDIUM SQUARE
        /// </summary>
        public static readonly Emoji WhiteMediumSquare = new("\U000025FB");

        /// <summary>
        /// ◼ - BLACK MEDIUM SQUARE
        /// </summary>
        public static readonly Emoji BlackMediumSquare = new("\U000025FC");

        /// <summary>
        /// ◽ - WHITE MEDIUM SMALL SQUARE white medium-small square
        /// </summary>
        public static readonly Emoji WhiteMediumSmallSquareWhiteMediumSmallSquare = new("\U000025FD");

        /// <summary>
        /// ◾ - BLACK MEDIUM SMALL SQUARE black medium-small square
        /// </summary>
        public static readonly Emoji BlackMediumSmallSquareBlackMediumSmallSquare = new("\U000025FE");

        /// <summary>
        /// ⬛ - BLACK LARGE SQUARE
        /// </summary>
        public static readonly Emoji BlackLargeSquare = new("\U00002B1B");

        /// <summary>
        /// ⬜ - WHITE LARGE SQUARE
        /// </summary>
        public static readonly Emoji WhiteLargeSquare = new("\U00002B1C");

        /// <summary>
        /// 🔶 - LARGE ORANGE DIAMOND
        /// </summary>
        public static readonly Emoji LargeOrangeDiamond = new("\U0001F536");

        /// <summary>
        /// 🔷 - LARGE BLUE DIAMOND
        /// </summary>
        public static readonly Emoji LargeBlueDiamond = new("\U0001F537");

        /// <summary>
        /// 🔸 - SMALL ORANGE DIAMOND
        /// </summary>
        public static readonly Emoji SmallOrangeDiamond = new("\U0001F538");

        /// <summary>
        /// 🔹 - SMALL BLUE DIAMOND
        /// </summary>
        public static readonly Emoji SmallBlueDiamond = new("\U0001F539");

        /// <summary>
        /// 🔺 - UP-POINTING RED TRIANGLE red triangle pointed up
        /// </summary>
        public static readonly Emoji UpPointingRedTriangleRedTrianglePointedUp = new("\U0001F53A");

        /// <summary>
        /// 🔻 - DOWN-POINTING RED TRIANGLE red triangle pointed down
        /// </summary>
        public static readonly Emoji DownPointingRedTriangleRedTrianglePointedDown = new("\U0001F53B");

        /// <summary>
        /// 💠 - DIAMOND SHAPE WITH A DOT INSIDE diamond with a dot
        /// </summary>
        public static readonly Emoji DiamondShapeWithADotInsideDiamondWithADot = new("\U0001F4A0");

        /// <summary>
        /// 🔘 - RADIO BUTTON
        /// </summary>
        public static readonly Emoji RadioButton = new("\U0001F518");

        /// <summary>
        /// 🔲 - BLACK SQUARE BUTTON
        /// </summary>
        public static readonly Emoji BlackSquareButton = new("\U0001F532");

        /// <summary>
        /// 🔳 - WHITE SQUARE BUTTON
        /// </summary>
        public static readonly Emoji WhiteSquareButton = new("\U0001F533");

        /// <summary>
        /// ⚪ - MEDIUM WHITE CIRCLE white circle
        /// </summary>
        public static readonly Emoji MediumWhiteCircleWhiteCircle = new("\U000026AA");

        /// <summary>
        /// ⚫ - MEDIUM BLACK CIRCLE black circle
        /// </summary>
        public static readonly Emoji MediumBlackCircleBlackCircle = new("\U000026AB");

        /// <summary>
        /// 🔴 - LARGE RED CIRCLE red circle
        /// </summary>
        public static readonly Emoji LargeRedCircleRedCircle = new("\U0001F534");

        /// <summary>
        /// 🔵 - LARGE BLUE CIRCLE blue circle
        /// </summary>
        public static readonly Emoji LargeBlueCircleBlueCircle = new("\U0001F535");
    }

    /// <summary>
    /// Flags
    /// </summary>
    public static class Flags
    {
        /// <summary>
        /// 🏁 - CHEQUERED FLAG
        /// </summary>
        public static readonly Emoji ChequeredFlag = new("\U0001F3C1");

        /// <summary>
        /// 🚩 - TRIANGULAR FLAG ON POST triangular flag
        /// </summary>
        public static readonly Emoji TriangularFlagOnPostTriangularFlag = new("\U0001F6A9");

        /// <summary>
        /// 🎌 - CROSSED FLAGS
        /// </summary>
        public static readonly Emoji CrossedFlags = new("\U0001F38C");

        /// <summary>
        /// 🏴 - WAVING BLACK FLAG
        /// </summary>
        public static readonly Emoji WavingBlackFlag = new("\U0001F3F4");

        /// <summary>
        /// 🏳 - WAVING WHITE FLAG
        /// </summary>
        public static readonly Emoji WavingWhiteFlag = new("\U0001F3F3");

        /// <summary>
        /// 🇦🇨 - REGIONAL INDICATOR SYMBOL LETTER A And REGIONAL INDICATOR SYMBOL LETTER C
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterAAndRegionalIndicatorSymbolLetterC = new("\U0001F1E6\U0001F1E8");

        /// <summary>
        /// 🇦🇩 - REGIONAL INDICATOR SYMBOL LETTER A And REGIONAL INDICATOR SYMBOL LETTER D
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterAAndRegionalIndicatorSymbolLetterD = new("\U0001F1E6\U0001F1E9");

        /// <summary>
        /// 🇦🇪 - REGIONAL INDICATOR SYMBOL LETTER A And REGIONAL INDICATOR SYMBOL LETTER E
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterAAndRegionalIndicatorSymbolLetterE = new("\U0001F1E6\U0001F1EA");

        /// <summary>
        /// 🇦🇫 - REGIONAL INDICATOR SYMBOL LETTER A And REGIONAL INDICATOR SYMBOL LETTER F
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterAAndRegionalIndicatorSymbolLetterF = new("\U0001F1E6\U0001F1EB");

        /// <summary>
        /// 🇦🇬 - REGIONAL INDICATOR SYMBOL LETTER A And REGIONAL INDICATOR SYMBOL LETTER G
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterAAndRegionalIndicatorSymbolLetterG = new("\U0001F1E6\U0001F1EC");

        /// <summary>
        /// 🇦🇮 - REGIONAL INDICATOR SYMBOL LETTER A And REGIONAL INDICATOR SYMBOL LETTER I
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterAAndRegionalIndicatorSymbolLetterI = new("\U0001F1E6\U0001F1EE");

        /// <summary>
        /// 🇦🇱 - REGIONAL INDICATOR SYMBOL LETTER A And REGIONAL INDICATOR SYMBOL LETTER L
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterAAndRegionalIndicatorSymbolLetterL = new("\U0001F1E6\U0001F1F1");

        /// <summary>
        /// 🇦🇲 - REGIONAL INDICATOR SYMBOL LETTER A And REGIONAL INDICATOR SYMBOL LETTER M
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterAAndRegionalIndicatorSymbolLetterM = new("\U0001F1E6\U0001F1F2");

        /// <summary>
        /// 🇦🇴 - REGIONAL INDICATOR SYMBOL LETTER A And REGIONAL INDICATOR SYMBOL LETTER O
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterAAndRegionalIndicatorSymbolLetterO = new("\U0001F1E6\U0001F1F4");

        /// <summary>
        /// 🇦🇶 - REGIONAL INDICATOR SYMBOL LETTER A And REGIONAL INDICATOR SYMBOL LETTER Q
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterAAndRegionalIndicatorSymbolLetterQ = new("\U0001F1E6\U0001F1F6");

        /// <summary>
        /// 🇦🇷 - REGIONAL INDICATOR SYMBOL LETTER A And REGIONAL INDICATOR SYMBOL LETTER R
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterAAndRegionalIndicatorSymbolLetterR = new("\U0001F1E6\U0001F1F7");

        /// <summary>
        /// 🇦🇸 - REGIONAL INDICATOR SYMBOL LETTER A And REGIONAL INDICATOR SYMBOL LETTER S
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterAAndRegionalIndicatorSymbolLetterS = new("\U0001F1E6\U0001F1F8");

        /// <summary>
        /// 🇦🇹 - REGIONAL INDICATOR SYMBOL LETTER A And REGIONAL INDICATOR SYMBOL LETTER T
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterAAndRegionalIndicatorSymbolLetterT = new("\U0001F1E6\U0001F1F9");

        /// <summary>
        /// 🇦🇺 - REGIONAL INDICATOR SYMBOL LETTER A And REGIONAL INDICATOR SYMBOL LETTER U
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterAAndRegionalIndicatorSymbolLetterU = new("\U0001F1E6\U0001F1FA");

        /// <summary>
        /// 🇦🇼 - REGIONAL INDICATOR SYMBOL LETTER A And REGIONAL INDICATOR SYMBOL LETTER W
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterAAndRegionalIndicatorSymbolLetterW = new("\U0001F1E6\U0001F1FC");

        /// <summary>
        /// 🇦🇽 - REGIONAL INDICATOR SYMBOL LETTER A And REGIONAL INDICATOR SYMBOL LETTER X
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterAAndRegionalIndicatorSymbolLetterX = new("\U0001F1E6\U0001F1FD");

        /// <summary>
        /// 🇦🇿 - REGIONAL INDICATOR SYMBOL LETTER A And REGIONAL INDICATOR SYMBOL LETTER Z
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterAAndRegionalIndicatorSymbolLetterZ = new("\U0001F1E6\U0001F1FF");

        /// <summary>
        /// 🇧🇦 - REGIONAL INDICATOR SYMBOL LETTER B And REGIONAL INDICATOR SYMBOL LETTER A
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterBAndRegionalIndicatorSymbolLetterA = new("\U0001F1E7\U0001F1E6");

        /// <summary>
        /// 🇧🇧 - REGIONAL INDICATOR SYMBOL LETTER B And REGIONAL INDICATOR SYMBOL LETTER B
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterBAndRegionalIndicatorSymbolLetterB = new("\U0001F1E7\U0001F1E7");

        /// <summary>
        /// 🇧🇩 - REGIONAL INDICATOR SYMBOL LETTER B And REGIONAL INDICATOR SYMBOL LETTER D
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterBAndRegionalIndicatorSymbolLetterD = new("\U0001F1E7\U0001F1E9");

        /// <summary>
        /// 🇧🇪 - REGIONAL INDICATOR SYMBOL LETTER B And REGIONAL INDICATOR SYMBOL LETTER E
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterBAndRegionalIndicatorSymbolLetterE = new("\U0001F1E7\U0001F1EA");

        /// <summary>
        /// 🇧🇫 - REGIONAL INDICATOR SYMBOL LETTER B And REGIONAL INDICATOR SYMBOL LETTER F
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterBAndRegionalIndicatorSymbolLetterF = new("\U0001F1E7\U0001F1EB");

        /// <summary>
        /// 🇧🇬 - REGIONAL INDICATOR SYMBOL LETTER B And REGIONAL INDICATOR SYMBOL LETTER G
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterBAndRegionalIndicatorSymbolLetterG = new("\U0001F1E7\U0001F1EC");

        /// <summary>
        /// 🇧🇭 - REGIONAL INDICATOR SYMBOL LETTER B And REGIONAL INDICATOR SYMBOL LETTER H
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterBAndRegionalIndicatorSymbolLetterH = new("\U0001F1E7\U0001F1ED");

        /// <summary>
        /// 🇧🇮 - REGIONAL INDICATOR SYMBOL LETTER B And REGIONAL INDICATOR SYMBOL LETTER I
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterBAndRegionalIndicatorSymbolLetterI = new("\U0001F1E7\U0001F1EE");

        /// <summary>
        /// 🇧🇯 - REGIONAL INDICATOR SYMBOL LETTER B And REGIONAL INDICATOR SYMBOL LETTER J
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterBAndRegionalIndicatorSymbolLetterJ = new("\U0001F1E7\U0001F1EF");

        /// <summary>
        /// 🇧🇱 - REGIONAL INDICATOR SYMBOL LETTER B And REGIONAL INDICATOR SYMBOL LETTER L
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterBAndRegionalIndicatorSymbolLetterL = new("\U0001F1E7\U0001F1F1");

        /// <summary>
        /// 🇧🇲 - REGIONAL INDICATOR SYMBOL LETTER B And REGIONAL INDICATOR SYMBOL LETTER M
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterBAndRegionalIndicatorSymbolLetterM = new("\U0001F1E7\U0001F1F2");

        /// <summary>
        /// 🇧🇳 - REGIONAL INDICATOR SYMBOL LETTER B And REGIONAL INDICATOR SYMBOL LETTER N
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterBAndRegionalIndicatorSymbolLetterN = new("\U0001F1E7\U0001F1F3");

        /// <summary>
        /// 🇧🇴 - REGIONAL INDICATOR SYMBOL LETTER B And REGIONAL INDICATOR SYMBOL LETTER O
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterBAndRegionalIndicatorSymbolLetterO = new("\U0001F1E7\U0001F1F4");

        /// <summary>
        /// 🇧🇶 - REGIONAL INDICATOR SYMBOL LETTER B And REGIONAL INDICATOR SYMBOL LETTER Q
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterBAndRegionalIndicatorSymbolLetterQ = new("\U0001F1E7\U0001F1F6");

        /// <summary>
        /// 🇧🇷 - REGIONAL INDICATOR SYMBOL LETTER B And REGIONAL INDICATOR SYMBOL LETTER R
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterBAndRegionalIndicatorSymbolLetterR = new("\U0001F1E7\U0001F1F7");

        /// <summary>
        /// 🇧🇸 - REGIONAL INDICATOR SYMBOL LETTER B And REGIONAL INDICATOR SYMBOL LETTER S
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterBAndRegionalIndicatorSymbolLetterS = new("\U0001F1E7\U0001F1F8");

        /// <summary>
        /// 🇧🇹 - REGIONAL INDICATOR SYMBOL LETTER B And REGIONAL INDICATOR SYMBOL LETTER T
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterBAndRegionalIndicatorSymbolLetterT = new("\U0001F1E7\U0001F1F9");

        /// <summary>
        /// 🇧🇻 - REGIONAL INDICATOR SYMBOL LETTER B And REGIONAL INDICATOR SYMBOL LETTER V
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterBAndRegionalIndicatorSymbolLetterV = new("\U0001F1E7\U0001F1FB");

        /// <summary>
        /// 🇧🇼 - REGIONAL INDICATOR SYMBOL LETTER B And REGIONAL INDICATOR SYMBOL LETTER W
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterBAndRegionalIndicatorSymbolLetterW = new("\U0001F1E7\U0001F1FC");

        /// <summary>
        /// 🇧🇾 - REGIONAL INDICATOR SYMBOL LETTER B And REGIONAL INDICATOR SYMBOL LETTER Y
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterBAndRegionalIndicatorSymbolLetterY = new("\U0001F1E7\U0001F1FE");

        /// <summary>
        /// 🇧🇿 - REGIONAL INDICATOR SYMBOL LETTER B And REGIONAL INDICATOR SYMBOL LETTER Z
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterBAndRegionalIndicatorSymbolLetterZ = new("\U0001F1E7\U0001F1FF");

        /// <summary>
        /// 🇨🇦 - REGIONAL INDICATOR SYMBOL LETTER C And REGIONAL INDICATOR SYMBOL LETTER A
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterCAndRegionalIndicatorSymbolLetterA = new("\U0001F1E8\U0001F1E6");

        /// <summary>
        /// 🇨🇨 - REGIONAL INDICATOR SYMBOL LETTER C And REGIONAL INDICATOR SYMBOL LETTER C
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterCAndRegionalIndicatorSymbolLetterC = new("\U0001F1E8\U0001F1E8");

        /// <summary>
        /// 🇨🇩 - REGIONAL INDICATOR SYMBOL LETTER C And REGIONAL INDICATOR SYMBOL LETTER D
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterCAndRegionalIndicatorSymbolLetterD = new("\U0001F1E8\U0001F1E9");

        /// <summary>
        /// 🇨🇫 - REGIONAL INDICATOR SYMBOL LETTER C And REGIONAL INDICATOR SYMBOL LETTER F
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterCAndRegionalIndicatorSymbolLetterF = new("\U0001F1E8\U0001F1EB");

        /// <summary>
        /// 🇨🇬 - REGIONAL INDICATOR SYMBOL LETTER C And REGIONAL INDICATOR SYMBOL LETTER G
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterCAndRegionalIndicatorSymbolLetterG = new("\U0001F1E8\U0001F1EC");

        /// <summary>
        /// 🇨🇭 - REGIONAL INDICATOR SYMBOL LETTER C And REGIONAL INDICATOR SYMBOL LETTER H
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterCAndRegionalIndicatorSymbolLetterH = new("\U0001F1E8\U0001F1ED");

        /// <summary>
        /// 🇨🇮 - REGIONAL INDICATOR SYMBOL LETTER C And REGIONAL INDICATOR SYMBOL LETTER I
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterCAndRegionalIndicatorSymbolLetterI = new("\U0001F1E8\U0001F1EE");

        /// <summary>
        /// 🇨🇰 - REGIONAL INDICATOR SYMBOL LETTER C And REGIONAL INDICATOR SYMBOL LETTER K
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterCAndRegionalIndicatorSymbolLetterK = new("\U0001F1E8\U0001F1F0");

        /// <summary>
        /// 🇨🇱 - REGIONAL INDICATOR SYMBOL LETTER C And REGIONAL INDICATOR SYMBOL LETTER L
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterCAndRegionalIndicatorSymbolLetterL = new("\U0001F1E8\U0001F1F1");

        /// <summary>
        /// 🇨🇲 - REGIONAL INDICATOR SYMBOL LETTER C And REGIONAL INDICATOR SYMBOL LETTER M
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterCAndRegionalIndicatorSymbolLetterM = new("\U0001F1E8\U0001F1F2");

        /// <summary>
        /// 🇨🇳 - REGIONAL INDICATOR SYMBOL LETTER C And REGIONAL INDICATOR SYMBOL LETTER N
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterCAndRegionalIndicatorSymbolLetterN = new("\U0001F1E8\U0001F1F3");

        /// <summary>
        /// 🇨🇴 - REGIONAL INDICATOR SYMBOL LETTER C And REGIONAL INDICATOR SYMBOL LETTER O
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterCAndRegionalIndicatorSymbolLetterO = new("\U0001F1E8\U0001F1F4");

        /// <summary>
        /// 🇨🇵 - REGIONAL INDICATOR SYMBOL LETTER C And REGIONAL INDICATOR SYMBOL LETTER P
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterCAndRegionalIndicatorSymbolLetterP = new("\U0001F1E8\U0001F1F5");

        /// <summary>
        /// 🇨🇷 - REGIONAL INDICATOR SYMBOL LETTER C And REGIONAL INDICATOR SYMBOL LETTER R
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterCAndRegionalIndicatorSymbolLetterR = new("\U0001F1E8\U0001F1F7");

        /// <summary>
        /// 🇨🇺 - REGIONAL INDICATOR SYMBOL LETTER C And REGIONAL INDICATOR SYMBOL LETTER U
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterCAndRegionalIndicatorSymbolLetterU = new("\U0001F1E8\U0001F1FA");

        /// <summary>
        /// 🇨🇻 - REGIONAL INDICATOR SYMBOL LETTER C And REGIONAL INDICATOR SYMBOL LETTER V
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterCAndRegionalIndicatorSymbolLetterV = new("\U0001F1E8\U0001F1FB");

        /// <summary>
        /// 🇨🇼 - REGIONAL INDICATOR SYMBOL LETTER C And REGIONAL INDICATOR SYMBOL LETTER W
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterCAndRegionalIndicatorSymbolLetterW = new("\U0001F1E8\U0001F1FC");

        /// <summary>
        /// 🇨🇽 - REGIONAL INDICATOR SYMBOL LETTER C And REGIONAL INDICATOR SYMBOL LETTER X
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterCAndRegionalIndicatorSymbolLetterX = new("\U0001F1E8\U0001F1FD");

        /// <summary>
        /// 🇨🇾 - REGIONAL INDICATOR SYMBOL LETTER C And REGIONAL INDICATOR SYMBOL LETTER Y
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterCAndRegionalIndicatorSymbolLetterY = new("\U0001F1E8\U0001F1FE");

        /// <summary>
        /// 🇨🇿 - REGIONAL INDICATOR SYMBOL LETTER C And REGIONAL INDICATOR SYMBOL LETTER Z
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterCAndRegionalIndicatorSymbolLetterZ = new("\U0001F1E8\U0001F1FF");

        /// <summary>
        /// 🇩🇪 - REGIONAL INDICATOR SYMBOL LETTER D And REGIONAL INDICATOR SYMBOL LETTER E
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterDAndRegionalIndicatorSymbolLetterE = new("\U0001F1E9\U0001F1EA");

        /// <summary>
        /// 🇩🇬 - REGIONAL INDICATOR SYMBOL LETTER D And REGIONAL INDICATOR SYMBOL LETTER G
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterDAndRegionalIndicatorSymbolLetterG = new("\U0001F1E9\U0001F1EC");

        /// <summary>
        /// 🇩🇯 - REGIONAL INDICATOR SYMBOL LETTER D And REGIONAL INDICATOR SYMBOL LETTER J
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterDAndRegionalIndicatorSymbolLetterJ = new("\U0001F1E9\U0001F1EF");

        /// <summary>
        /// 🇩🇰 - REGIONAL INDICATOR SYMBOL LETTER D And REGIONAL INDICATOR SYMBOL LETTER K
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterDAndRegionalIndicatorSymbolLetterK = new("\U0001F1E9\U0001F1F0");

        /// <summary>
        /// 🇩🇲 - REGIONAL INDICATOR SYMBOL LETTER D And REGIONAL INDICATOR SYMBOL LETTER M
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterDAndRegionalIndicatorSymbolLetterM = new("\U0001F1E9\U0001F1F2");

        /// <summary>
        /// 🇩🇴 - REGIONAL INDICATOR SYMBOL LETTER D And REGIONAL INDICATOR SYMBOL LETTER O
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterDAndRegionalIndicatorSymbolLetterO = new("\U0001F1E9\U0001F1F4");

        /// <summary>
        /// 🇩🇿 - REGIONAL INDICATOR SYMBOL LETTER D And REGIONAL INDICATOR SYMBOL LETTER Z
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterDAndRegionalIndicatorSymbolLetterZ = new("\U0001F1E9\U0001F1FF");

        /// <summary>
        /// 🇪🇦 - REGIONAL INDICATOR SYMBOL LETTER E And REGIONAL INDICATOR SYMBOL LETTER A
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterEAndRegionalIndicatorSymbolLetterA = new("\U0001F1EA\U0001F1E6");

        /// <summary>
        /// 🇪🇨 - REGIONAL INDICATOR SYMBOL LETTER E And REGIONAL INDICATOR SYMBOL LETTER C
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterEAndRegionalIndicatorSymbolLetterC = new("\U0001F1EA\U0001F1E8");

        /// <summary>
        /// 🇪🇪 - REGIONAL INDICATOR SYMBOL LETTER E And REGIONAL INDICATOR SYMBOL LETTER E
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterEAndRegionalIndicatorSymbolLetterE = new("\U0001F1EA\U0001F1EA");

        /// <summary>
        /// 🇪🇬 - REGIONAL INDICATOR SYMBOL LETTER E And REGIONAL INDICATOR SYMBOL LETTER G
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterEAndRegionalIndicatorSymbolLetterG = new("\U0001F1EA\U0001F1EC");

        /// <summary>
        /// 🇪🇭 - REGIONAL INDICATOR SYMBOL LETTER E And REGIONAL INDICATOR SYMBOL LETTER H
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterEAndRegionalIndicatorSymbolLetterH = new("\U0001F1EA\U0001F1ED");

        /// <summary>
        /// 🇪🇷 - REGIONAL INDICATOR SYMBOL LETTER E And REGIONAL INDICATOR SYMBOL LETTER R
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterEAndRegionalIndicatorSymbolLetterR = new("\U0001F1EA\U0001F1F7");

        /// <summary>
        /// 🇪🇸 - REGIONAL INDICATOR SYMBOL LETTER E And REGIONAL INDICATOR SYMBOL LETTER S
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterEAndRegionalIndicatorSymbolLetterS = new("\U0001F1EA\U0001F1F8");

        /// <summary>
        /// 🇪🇹 - REGIONAL INDICATOR SYMBOL LETTER E And REGIONAL INDICATOR SYMBOL LETTER T
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterEAndRegionalIndicatorSymbolLetterT = new("\U0001F1EA\U0001F1F9");

        /// <summary>
        /// 🇪🇺 - REGIONAL INDICATOR SYMBOL LETTER E And REGIONAL INDICATOR SYMBOL LETTER U
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterEAndRegionalIndicatorSymbolLetterU = new("\U0001F1EA\U0001F1FA");

        /// <summary>
        /// 🇫🇮 - REGIONAL INDICATOR SYMBOL LETTER F And REGIONAL INDICATOR SYMBOL LETTER I
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterFAndRegionalIndicatorSymbolLetterI = new("\U0001F1EB\U0001F1EE");

        /// <summary>
        /// 🇫🇯 - REGIONAL INDICATOR SYMBOL LETTER F And REGIONAL INDICATOR SYMBOL LETTER J
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterFAndRegionalIndicatorSymbolLetterJ = new("\U0001F1EB\U0001F1EF");

        /// <summary>
        /// 🇫🇰 - REGIONAL INDICATOR SYMBOL LETTER F And REGIONAL INDICATOR SYMBOL LETTER K
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterFAndRegionalIndicatorSymbolLetterK = new("\U0001F1EB\U0001F1F0");

        /// <summary>
        /// 🇫🇲 - REGIONAL INDICATOR SYMBOL LETTER F And REGIONAL INDICATOR SYMBOL LETTER M
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterFAndRegionalIndicatorSymbolLetterM = new("\U0001F1EB\U0001F1F2");

        /// <summary>
        /// 🇫🇴 - REGIONAL INDICATOR SYMBOL LETTER F And REGIONAL INDICATOR SYMBOL LETTER O
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterFAndRegionalIndicatorSymbolLetterO = new("\U0001F1EB\U0001F1F4");

        /// <summary>
        /// 🇫🇷 - REGIONAL INDICATOR SYMBOL LETTER F And REGIONAL INDICATOR SYMBOL LETTER R
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterFAndRegionalIndicatorSymbolLetterR = new("\U0001F1EB\U0001F1F7");

        /// <summary>
        /// 🇬🇦 - REGIONAL INDICATOR SYMBOL LETTER G And REGIONAL INDICATOR SYMBOL LETTER A
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterGAndRegionalIndicatorSymbolLetterA = new("\U0001F1EC\U0001F1E6");

        /// <summary>
        /// 🇬🇧 - REGIONAL INDICATOR SYMBOL LETTER G And REGIONAL INDICATOR SYMBOL LETTER B
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterGAndRegionalIndicatorSymbolLetterB = new("\U0001F1EC\U0001F1E7");

        /// <summary>
        /// 🇬🇩 - REGIONAL INDICATOR SYMBOL LETTER G And REGIONAL INDICATOR SYMBOL LETTER D
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterGAndRegionalIndicatorSymbolLetterD = new("\U0001F1EC\U0001F1E9");

        /// <summary>
        /// 🇬🇪 - REGIONAL INDICATOR SYMBOL LETTER G And REGIONAL INDICATOR SYMBOL LETTER E
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterGAndRegionalIndicatorSymbolLetterE = new("\U0001F1EC\U0001F1EA");

        /// <summary>
        /// 🇬🇫 - REGIONAL INDICATOR SYMBOL LETTER G And REGIONAL INDICATOR SYMBOL LETTER F
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterGAndRegionalIndicatorSymbolLetterF = new("\U0001F1EC\U0001F1EB");

        /// <summary>
        /// 🇬🇬 - REGIONAL INDICATOR SYMBOL LETTER G And REGIONAL INDICATOR SYMBOL LETTER G
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterGAndRegionalIndicatorSymbolLetterG = new("\U0001F1EC\U0001F1EC");

        /// <summary>
        /// 🇬🇭 - REGIONAL INDICATOR SYMBOL LETTER G And REGIONAL INDICATOR SYMBOL LETTER H
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterGAndRegionalIndicatorSymbolLetterH = new("\U0001F1EC\U0001F1ED");

        /// <summary>
        /// 🇬🇮 - REGIONAL INDICATOR SYMBOL LETTER G And REGIONAL INDICATOR SYMBOL LETTER I
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterGAndRegionalIndicatorSymbolLetterI = new("\U0001F1EC\U0001F1EE");

        /// <summary>
        /// 🇬🇱 - REGIONAL INDICATOR SYMBOL LETTER G And REGIONAL INDICATOR SYMBOL LETTER L
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterGAndRegionalIndicatorSymbolLetterL = new("\U0001F1EC\U0001F1F1");

        /// <summary>
        /// 🇬🇲 - REGIONAL INDICATOR SYMBOL LETTER G And REGIONAL INDICATOR SYMBOL LETTER M
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterGAndRegionalIndicatorSymbolLetterM = new("\U0001F1EC\U0001F1F2");

        /// <summary>
        /// 🇬🇳 - REGIONAL INDICATOR SYMBOL LETTER G And REGIONAL INDICATOR SYMBOL LETTER N
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterGAndRegionalIndicatorSymbolLetterN = new("\U0001F1EC\U0001F1F3");

        /// <summary>
        /// 🇬🇵 - REGIONAL INDICATOR SYMBOL LETTER G And REGIONAL INDICATOR SYMBOL LETTER P
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterGAndRegionalIndicatorSymbolLetterP = new("\U0001F1EC\U0001F1F5");

        /// <summary>
        /// 🇬🇶 - REGIONAL INDICATOR SYMBOL LETTER G And REGIONAL INDICATOR SYMBOL LETTER Q
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterGAndRegionalIndicatorSymbolLetterQ = new("\U0001F1EC\U0001F1F6");

        /// <summary>
        /// 🇬🇷 - REGIONAL INDICATOR SYMBOL LETTER G And REGIONAL INDICATOR SYMBOL LETTER R
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterGAndRegionalIndicatorSymbolLetterR = new("\U0001F1EC\U0001F1F7");

        /// <summary>
        /// 🇬🇸 - REGIONAL INDICATOR SYMBOL LETTER G And REGIONAL INDICATOR SYMBOL LETTER S
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterGAndRegionalIndicatorSymbolLetterS = new("\U0001F1EC\U0001F1F8");

        /// <summary>
        /// 🇬🇹 - REGIONAL INDICATOR SYMBOL LETTER G And REGIONAL INDICATOR SYMBOL LETTER T
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterGAndRegionalIndicatorSymbolLetterT = new("\U0001F1EC\U0001F1F9");

        /// <summary>
        /// 🇬🇺 - REGIONAL INDICATOR SYMBOL LETTER G And REGIONAL INDICATOR SYMBOL LETTER U
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterGAndRegionalIndicatorSymbolLetterU = new("\U0001F1EC\U0001F1FA");

        /// <summary>
        /// 🇬🇼 - REGIONAL INDICATOR SYMBOL LETTER G And REGIONAL INDICATOR SYMBOL LETTER W
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterGAndRegionalIndicatorSymbolLetterW = new("\U0001F1EC\U0001F1FC");

        /// <summary>
        /// 🇬🇾 - REGIONAL INDICATOR SYMBOL LETTER G And REGIONAL INDICATOR SYMBOL LETTER Y
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterGAndRegionalIndicatorSymbolLetterY = new("\U0001F1EC\U0001F1FE");

        /// <summary>
        /// 🇭🇰 - REGIONAL INDICATOR SYMBOL LETTER H And REGIONAL INDICATOR SYMBOL LETTER K
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterHAndRegionalIndicatorSymbolLetterK = new("\U0001F1ED\U0001F1F0");

        /// <summary>
        /// 🇭🇲 - REGIONAL INDICATOR SYMBOL LETTER H And REGIONAL INDICATOR SYMBOL LETTER M
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterHAndRegionalIndicatorSymbolLetterM = new("\U0001F1ED\U0001F1F2");

        /// <summary>
        /// 🇭🇳 - REGIONAL INDICATOR SYMBOL LETTER H And REGIONAL INDICATOR SYMBOL LETTER N
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterHAndRegionalIndicatorSymbolLetterN = new("\U0001F1ED\U0001F1F3");

        /// <summary>
        /// 🇭🇷 - REGIONAL INDICATOR SYMBOL LETTER H And REGIONAL INDICATOR SYMBOL LETTER R
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterHAndRegionalIndicatorSymbolLetterR = new("\U0001F1ED\U0001F1F7");

        /// <summary>
        /// 🇭🇹 - REGIONAL INDICATOR SYMBOL LETTER H And REGIONAL INDICATOR SYMBOL LETTER T
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterHAndRegionalIndicatorSymbolLetterT = new("\U0001F1ED\U0001F1F9");

        /// <summary>
        /// 🇭🇺 - REGIONAL INDICATOR SYMBOL LETTER H And REGIONAL INDICATOR SYMBOL LETTER U
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterHAndRegionalIndicatorSymbolLetterU = new("\U0001F1ED\U0001F1FA");

        /// <summary>
        /// 🇮🇨 - REGIONAL INDICATOR SYMBOL LETTER I And REGIONAL INDICATOR SYMBOL LETTER C
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterIAndRegionalIndicatorSymbolLetterC = new("\U0001F1EE\U0001F1E8");

        /// <summary>
        /// 🇮🇩 - REGIONAL INDICATOR SYMBOL LETTER I And REGIONAL INDICATOR SYMBOL LETTER D
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterIAndRegionalIndicatorSymbolLetterD = new("\U0001F1EE\U0001F1E9");

        /// <summary>
        /// 🇮🇪 - REGIONAL INDICATOR SYMBOL LETTER I And REGIONAL INDICATOR SYMBOL LETTER E
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterIAndRegionalIndicatorSymbolLetterE = new("\U0001F1EE\U0001F1EA");

        /// <summary>
        /// 🇮🇱 - REGIONAL INDICATOR SYMBOL LETTER I And REGIONAL INDICATOR SYMBOL LETTER L
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterIAndRegionalIndicatorSymbolLetterL = new("\U0001F1EE\U0001F1F1");

        /// <summary>
        /// 🇮🇲 - REGIONAL INDICATOR SYMBOL LETTER I And REGIONAL INDICATOR SYMBOL LETTER M
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterIAndRegionalIndicatorSymbolLetterM = new("\U0001F1EE\U0001F1F2");

        /// <summary>
        /// 🇮🇳 - REGIONAL INDICATOR SYMBOL LETTER I And REGIONAL INDICATOR SYMBOL LETTER N
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterIAndRegionalIndicatorSymbolLetterN = new("\U0001F1EE\U0001F1F3");

        /// <summary>
        /// 🇮🇴 - REGIONAL INDICATOR SYMBOL LETTER I And REGIONAL INDICATOR SYMBOL LETTER O
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterIAndRegionalIndicatorSymbolLetterO = new("\U0001F1EE\U0001F1F4");

        /// <summary>
        /// 🇮🇶 - REGIONAL INDICATOR SYMBOL LETTER I And REGIONAL INDICATOR SYMBOL LETTER Q
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterIAndRegionalIndicatorSymbolLetterQ = new("\U0001F1EE\U0001F1F6");

        /// <summary>
        /// 🇮🇷 - REGIONAL INDICATOR SYMBOL LETTER I And REGIONAL INDICATOR SYMBOL LETTER R
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterIAndRegionalIndicatorSymbolLetterR = new("\U0001F1EE\U0001F1F7");

        /// <summary>
        /// 🇮🇸 - REGIONAL INDICATOR SYMBOL LETTER I And REGIONAL INDICATOR SYMBOL LETTER S
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterIAndRegionalIndicatorSymbolLetterS = new("\U0001F1EE\U0001F1F8");

        /// <summary>
        /// 🇮🇹 - REGIONAL INDICATOR SYMBOL LETTER I And REGIONAL INDICATOR SYMBOL LETTER T
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterIAndRegionalIndicatorSymbolLetterT = new("\U0001F1EE\U0001F1F9");

        /// <summary>
        /// 🇯🇪 - REGIONAL INDICATOR SYMBOL LETTER J And REGIONAL INDICATOR SYMBOL LETTER E
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterJAndRegionalIndicatorSymbolLetterE = new("\U0001F1EF\U0001F1EA");

        /// <summary>
        /// 🇯🇲 - REGIONAL INDICATOR SYMBOL LETTER J And REGIONAL INDICATOR SYMBOL LETTER M
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterJAndRegionalIndicatorSymbolLetterM = new("\U0001F1EF\U0001F1F2");

        /// <summary>
        /// 🇯🇴 - REGIONAL INDICATOR SYMBOL LETTER J And REGIONAL INDICATOR SYMBOL LETTER O
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterJAndRegionalIndicatorSymbolLetterO = new("\U0001F1EF\U0001F1F4");

        /// <summary>
        /// 🇯🇵 - REGIONAL INDICATOR SYMBOL LETTER J And REGIONAL INDICATOR SYMBOL LETTER P
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterJAndRegionalIndicatorSymbolLetterP = new("\U0001F1EF\U0001F1F5");

        /// <summary>
        /// 🇰🇪 - REGIONAL INDICATOR SYMBOL LETTER K And REGIONAL INDICATOR SYMBOL LETTER E
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterKAndRegionalIndicatorSymbolLetterE = new("\U0001F1F0\U0001F1EA");

        /// <summary>
        /// 🇰🇬 - REGIONAL INDICATOR SYMBOL LETTER K And REGIONAL INDICATOR SYMBOL LETTER G
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterKAndRegionalIndicatorSymbolLetterG = new("\U0001F1F0\U0001F1EC");

        /// <summary>
        /// 🇰🇭 - REGIONAL INDICATOR SYMBOL LETTER K And REGIONAL INDICATOR SYMBOL LETTER H
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterKAndRegionalIndicatorSymbolLetterH = new("\U0001F1F0\U0001F1ED");

        /// <summary>
        /// 🇰🇮 - REGIONAL INDICATOR SYMBOL LETTER K And REGIONAL INDICATOR SYMBOL LETTER I
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterKAndRegionalIndicatorSymbolLetterI = new("\U0001F1F0\U0001F1EE");

        /// <summary>
        /// 🇰🇲 - REGIONAL INDICATOR SYMBOL LETTER K And REGIONAL INDICATOR SYMBOL LETTER M
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterKAndRegionalIndicatorSymbolLetterM = new("\U0001F1F0\U0001F1F2");

        /// <summary>
        /// 🇰🇳 - REGIONAL INDICATOR SYMBOL LETTER K And REGIONAL INDICATOR SYMBOL LETTER N
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterKAndRegionalIndicatorSymbolLetterN = new("\U0001F1F0\U0001F1F3");

        /// <summary>
        /// 🇰🇵 - REGIONAL INDICATOR SYMBOL LETTER K And REGIONAL INDICATOR SYMBOL LETTER P
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterKAndRegionalIndicatorSymbolLetterP = new("\U0001F1F0\U0001F1F5");

        /// <summary>
        /// 🇰🇷 - REGIONAL INDICATOR SYMBOL LETTER K And REGIONAL INDICATOR SYMBOL LETTER R
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterKAndRegionalIndicatorSymbolLetterR = new("\U0001F1F0\U0001F1F7");

        /// <summary>
        /// 🇰🇼 - REGIONAL INDICATOR SYMBOL LETTER K And REGIONAL INDICATOR SYMBOL LETTER W
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterKAndRegionalIndicatorSymbolLetterW = new("\U0001F1F0\U0001F1FC");

        /// <summary>
        /// 🇰🇾 - REGIONAL INDICATOR SYMBOL LETTER K And REGIONAL INDICATOR SYMBOL LETTER Y
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterKAndRegionalIndicatorSymbolLetterY = new("\U0001F1F0\U0001F1FE");

        /// <summary>
        /// 🇰🇿 - REGIONAL INDICATOR SYMBOL LETTER K And REGIONAL INDICATOR SYMBOL LETTER Z
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterKAndRegionalIndicatorSymbolLetterZ = new("\U0001F1F0\U0001F1FF");

        /// <summary>
        /// 🇱🇦 - REGIONAL INDICATOR SYMBOL LETTER L And REGIONAL INDICATOR SYMBOL LETTER A
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterLAndRegionalIndicatorSymbolLetterA = new("\U0001F1F1\U0001F1E6");

        /// <summary>
        /// 🇱🇧 - REGIONAL INDICATOR SYMBOL LETTER L And REGIONAL INDICATOR SYMBOL LETTER B
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterLAndRegionalIndicatorSymbolLetterB = new("\U0001F1F1\U0001F1E7");

        /// <summary>
        /// 🇱🇨 - REGIONAL INDICATOR SYMBOL LETTER L And REGIONAL INDICATOR SYMBOL LETTER C
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterLAndRegionalIndicatorSymbolLetterC = new("\U0001F1F1\U0001F1E8");

        /// <summary>
        /// 🇱🇮 - REGIONAL INDICATOR SYMBOL LETTER L And REGIONAL INDICATOR SYMBOL LETTER I
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterLAndRegionalIndicatorSymbolLetterI = new("\U0001F1F1\U0001F1EE");

        /// <summary>
        /// 🇱🇰 - REGIONAL INDICATOR SYMBOL LETTER L And REGIONAL INDICATOR SYMBOL LETTER K
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterLAndRegionalIndicatorSymbolLetterK = new("\U0001F1F1\U0001F1F0");

        /// <summary>
        /// 🇱🇷 - REGIONAL INDICATOR SYMBOL LETTER L And REGIONAL INDICATOR SYMBOL LETTER R
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterLAndRegionalIndicatorSymbolLetterR = new("\U0001F1F1\U0001F1F7");

        /// <summary>
        /// 🇱🇸 - REGIONAL INDICATOR SYMBOL LETTER L And REGIONAL INDICATOR SYMBOL LETTER S
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterLAndRegionalIndicatorSymbolLetterS = new("\U0001F1F1\U0001F1F8");

        /// <summary>
        /// 🇱🇹 - REGIONAL INDICATOR SYMBOL LETTER L And REGIONAL INDICATOR SYMBOL LETTER T
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterLAndRegionalIndicatorSymbolLetterT = new("\U0001F1F1\U0001F1F9");

        /// <summary>
        /// 🇱🇺 - REGIONAL INDICATOR SYMBOL LETTER L And REGIONAL INDICATOR SYMBOL LETTER U
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterLAndRegionalIndicatorSymbolLetterU = new("\U0001F1F1\U0001F1FA");

        /// <summary>
        /// 🇱🇻 - REGIONAL INDICATOR SYMBOL LETTER L And REGIONAL INDICATOR SYMBOL LETTER V
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterLAndRegionalIndicatorSymbolLetterV = new("\U0001F1F1\U0001F1FB");

        /// <summary>
        /// 🇱🇾 - REGIONAL INDICATOR SYMBOL LETTER L And REGIONAL INDICATOR SYMBOL LETTER Y
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterLAndRegionalIndicatorSymbolLetterY = new("\U0001F1F1\U0001F1FE");

        /// <summary>
        /// 🇲🇦 - REGIONAL INDICATOR SYMBOL LETTER M And REGIONAL INDICATOR SYMBOL LETTER A
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterMAndRegionalIndicatorSymbolLetterA = new("\U0001F1F2\U0001F1E6");

        /// <summary>
        /// 🇲🇨 - REGIONAL INDICATOR SYMBOL LETTER M And REGIONAL INDICATOR SYMBOL LETTER C
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterMAndRegionalIndicatorSymbolLetterC = new("\U0001F1F2\U0001F1E8");

        /// <summary>
        /// 🇲🇩 - REGIONAL INDICATOR SYMBOL LETTER M And REGIONAL INDICATOR SYMBOL LETTER D
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterMAndRegionalIndicatorSymbolLetterD = new("\U0001F1F2\U0001F1E9");

        /// <summary>
        /// 🇲🇪 - REGIONAL INDICATOR SYMBOL LETTER M And REGIONAL INDICATOR SYMBOL LETTER E
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterMAndRegionalIndicatorSymbolLetterE = new("\U0001F1F2\U0001F1EA");

        /// <summary>
        /// 🇲🇫 - REGIONAL INDICATOR SYMBOL LETTER M And REGIONAL INDICATOR SYMBOL LETTER F
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterMAndRegionalIndicatorSymbolLetterF = new("\U0001F1F2\U0001F1EB");

        /// <summary>
        /// 🇲🇬 - REGIONAL INDICATOR SYMBOL LETTER M And REGIONAL INDICATOR SYMBOL LETTER G
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterMAndRegionalIndicatorSymbolLetterG = new("\U0001F1F2\U0001F1EC");

        /// <summary>
        /// 🇲🇭 - REGIONAL INDICATOR SYMBOL LETTER M And REGIONAL INDICATOR SYMBOL LETTER H
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterMAndRegionalIndicatorSymbolLetterH = new("\U0001F1F2\U0001F1ED");

        /// <summary>
        /// 🇲🇰 - REGIONAL INDICATOR SYMBOL LETTER M And REGIONAL INDICATOR SYMBOL LETTER K
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterMAndRegionalIndicatorSymbolLetterK = new("\U0001F1F2\U0001F1F0");

        /// <summary>
        /// 🇲🇱 - REGIONAL INDICATOR SYMBOL LETTER M And REGIONAL INDICATOR SYMBOL LETTER L
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterMAndRegionalIndicatorSymbolLetterL = new("\U0001F1F2\U0001F1F1");

        /// <summary>
        /// 🇲🇲 - REGIONAL INDICATOR SYMBOL LETTER M And REGIONAL INDICATOR SYMBOL LETTER M
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterMAndRegionalIndicatorSymbolLetterM = new("\U0001F1F2\U0001F1F2");

        /// <summary>
        /// 🇲🇳 - REGIONAL INDICATOR SYMBOL LETTER M And REGIONAL INDICATOR SYMBOL LETTER N
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterMAndRegionalIndicatorSymbolLetterN = new("\U0001F1F2\U0001F1F3");

        /// <summary>
        /// 🇲🇴 - REGIONAL INDICATOR SYMBOL LETTER M And REGIONAL INDICATOR SYMBOL LETTER O
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterMAndRegionalIndicatorSymbolLetterO = new("\U0001F1F2\U0001F1F4");

        /// <summary>
        /// 🇲🇵 - REGIONAL INDICATOR SYMBOL LETTER M And REGIONAL INDICATOR SYMBOL LETTER P
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterMAndRegionalIndicatorSymbolLetterP = new("\U0001F1F2\U0001F1F5");

        /// <summary>
        /// 🇲🇶 - REGIONAL INDICATOR SYMBOL LETTER M And REGIONAL INDICATOR SYMBOL LETTER Q
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterMAndRegionalIndicatorSymbolLetterQ = new("\U0001F1F2\U0001F1F6");

        /// <summary>
        /// 🇲🇷 - REGIONAL INDICATOR SYMBOL LETTER M And REGIONAL INDICATOR SYMBOL LETTER R
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterMAndRegionalIndicatorSymbolLetterR = new("\U0001F1F2\U0001F1F7");

        /// <summary>
        /// 🇲🇸 - REGIONAL INDICATOR SYMBOL LETTER M And REGIONAL INDICATOR SYMBOL LETTER S
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterMAndRegionalIndicatorSymbolLetterS = new("\U0001F1F2\U0001F1F8");

        /// <summary>
        /// 🇲🇹 - REGIONAL INDICATOR SYMBOL LETTER M And REGIONAL INDICATOR SYMBOL LETTER T
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterMAndRegionalIndicatorSymbolLetterT = new("\U0001F1F2\U0001F1F9");

        /// <summary>
        /// 🇲🇺 - REGIONAL INDICATOR SYMBOL LETTER M And REGIONAL INDICATOR SYMBOL LETTER U
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterMAndRegionalIndicatorSymbolLetterU = new("\U0001F1F2\U0001F1FA");

        /// <summary>
        /// 🇲🇻 - REGIONAL INDICATOR SYMBOL LETTER M And REGIONAL INDICATOR SYMBOL LETTER V
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterMAndRegionalIndicatorSymbolLetterV = new("\U0001F1F2\U0001F1FB");

        /// <summary>
        /// 🇲🇼 - REGIONAL INDICATOR SYMBOL LETTER M And REGIONAL INDICATOR SYMBOL LETTER W
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterMAndRegionalIndicatorSymbolLetterW = new("\U0001F1F2\U0001F1FC");

        /// <summary>
        /// 🇲🇽 - REGIONAL INDICATOR SYMBOL LETTER M And REGIONAL INDICATOR SYMBOL LETTER X
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterMAndRegionalIndicatorSymbolLetterX = new("\U0001F1F2\U0001F1FD");

        /// <summary>
        /// 🇲🇾 - REGIONAL INDICATOR SYMBOL LETTER M And REGIONAL INDICATOR SYMBOL LETTER Y
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterMAndRegionalIndicatorSymbolLetterY = new("\U0001F1F2\U0001F1FE");

        /// <summary>
        /// 🇲🇿 - REGIONAL INDICATOR SYMBOL LETTER M And REGIONAL INDICATOR SYMBOL LETTER Z
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterMAndRegionalIndicatorSymbolLetterZ = new("\U0001F1F2\U0001F1FF");

        /// <summary>
        /// 🇳🇦 - REGIONAL INDICATOR SYMBOL LETTER N And REGIONAL INDICATOR SYMBOL LETTER A
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterNAndRegionalIndicatorSymbolLetterA = new("\U0001F1F3\U0001F1E6");

        /// <summary>
        /// 🇳🇨 - REGIONAL INDICATOR SYMBOL LETTER N And REGIONAL INDICATOR SYMBOL LETTER C
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterNAndRegionalIndicatorSymbolLetterC = new("\U0001F1F3\U0001F1E8");

        /// <summary>
        /// 🇳🇪 - REGIONAL INDICATOR SYMBOL LETTER N And REGIONAL INDICATOR SYMBOL LETTER E
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterNAndRegionalIndicatorSymbolLetterE = new("\U0001F1F3\U0001F1EA");

        /// <summary>
        /// 🇳🇫 - REGIONAL INDICATOR SYMBOL LETTER N And REGIONAL INDICATOR SYMBOL LETTER F
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterNAndRegionalIndicatorSymbolLetterF = new("\U0001F1F3\U0001F1EB");

        /// <summary>
        /// 🇳🇬 - REGIONAL INDICATOR SYMBOL LETTER N And REGIONAL INDICATOR SYMBOL LETTER G
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterNAndRegionalIndicatorSymbolLetterG = new("\U0001F1F3\U0001F1EC");

        /// <summary>
        /// 🇳🇮 - REGIONAL INDICATOR SYMBOL LETTER N And REGIONAL INDICATOR SYMBOL LETTER I
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterNAndRegionalIndicatorSymbolLetterI = new("\U0001F1F3\U0001F1EE");

        /// <summary>
        /// 🇳🇱 - REGIONAL INDICATOR SYMBOL LETTER N And REGIONAL INDICATOR SYMBOL LETTER L
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterNAndRegionalIndicatorSymbolLetterL = new("\U0001F1F3\U0001F1F1");

        /// <summary>
        /// 🇳🇴 - REGIONAL INDICATOR SYMBOL LETTER N And REGIONAL INDICATOR SYMBOL LETTER O
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterNAndRegionalIndicatorSymbolLetterO = new("\U0001F1F3\U0001F1F4");

        /// <summary>
        /// 🇳🇵 - REGIONAL INDICATOR SYMBOL LETTER N And REGIONAL INDICATOR SYMBOL LETTER P
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterNAndRegionalIndicatorSymbolLetterP = new("\U0001F1F3\U0001F1F5");

        /// <summary>
        /// 🇳🇷 - REGIONAL INDICATOR SYMBOL LETTER N And REGIONAL INDICATOR SYMBOL LETTER R
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterNAndRegionalIndicatorSymbolLetterR = new("\U0001F1F3\U0001F1F7");

        /// <summary>
        /// 🇳🇺 - REGIONAL INDICATOR SYMBOL LETTER N And REGIONAL INDICATOR SYMBOL LETTER U
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterNAndRegionalIndicatorSymbolLetterU = new("\U0001F1F3\U0001F1FA");

        /// <summary>
        /// 🇳🇿 - REGIONAL INDICATOR SYMBOL LETTER N And REGIONAL INDICATOR SYMBOL LETTER Z
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterNAndRegionalIndicatorSymbolLetterZ = new("\U0001F1F3\U0001F1FF");

        /// <summary>
        /// 🇴🇲 - REGIONAL INDICATOR SYMBOL LETTER O And REGIONAL INDICATOR SYMBOL LETTER M
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterOAndRegionalIndicatorSymbolLetterM = new("\U0001F1F4\U0001F1F2");

        /// <summary>
        /// 🇵🇦 - REGIONAL INDICATOR SYMBOL LETTER P And REGIONAL INDICATOR SYMBOL LETTER A
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterPAndRegionalIndicatorSymbolLetterA = new("\U0001F1F5\U0001F1E6");

        /// <summary>
        /// 🇵🇪 - REGIONAL INDICATOR SYMBOL LETTER P And REGIONAL INDICATOR SYMBOL LETTER E
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterPAndRegionalIndicatorSymbolLetterE = new("\U0001F1F5\U0001F1EA");

        /// <summary>
        /// 🇵🇫 - REGIONAL INDICATOR SYMBOL LETTER P And REGIONAL INDICATOR SYMBOL LETTER F
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterPAndRegionalIndicatorSymbolLetterF = new("\U0001F1F5\U0001F1EB");

        /// <summary>
        /// 🇵🇬 - REGIONAL INDICATOR SYMBOL LETTER P And REGIONAL INDICATOR SYMBOL LETTER G
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterPAndRegionalIndicatorSymbolLetterG = new("\U0001F1F5\U0001F1EC");

        /// <summary>
        /// 🇵🇭 - REGIONAL INDICATOR SYMBOL LETTER P And REGIONAL INDICATOR SYMBOL LETTER H
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterPAndRegionalIndicatorSymbolLetterH = new("\U0001F1F5\U0001F1ED");

        /// <summary>
        /// 🇵🇰 - REGIONAL INDICATOR SYMBOL LETTER P And REGIONAL INDICATOR SYMBOL LETTER K
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterPAndRegionalIndicatorSymbolLetterK = new("\U0001F1F5\U0001F1F0");

        /// <summary>
        /// 🇵🇱 - REGIONAL INDICATOR SYMBOL LETTER P And REGIONAL INDICATOR SYMBOL LETTER L
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterPAndRegionalIndicatorSymbolLetterL = new("\U0001F1F5\U0001F1F1");

        /// <summary>
        /// 🇵🇲 - REGIONAL INDICATOR SYMBOL LETTER P And REGIONAL INDICATOR SYMBOL LETTER M
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterPAndRegionalIndicatorSymbolLetterM = new("\U0001F1F5\U0001F1F2");

        /// <summary>
        /// 🇵🇳 - REGIONAL INDICATOR SYMBOL LETTER P And REGIONAL INDICATOR SYMBOL LETTER N
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterPAndRegionalIndicatorSymbolLetterN = new("\U0001F1F5\U0001F1F3");

        /// <summary>
        /// 🇵🇷 - REGIONAL INDICATOR SYMBOL LETTER P And REGIONAL INDICATOR SYMBOL LETTER R
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterPAndRegionalIndicatorSymbolLetterR = new("\U0001F1F5\U0001F1F7");

        /// <summary>
        /// 🇵🇸 - REGIONAL INDICATOR SYMBOL LETTER P And REGIONAL INDICATOR SYMBOL LETTER S
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterPAndRegionalIndicatorSymbolLetterS = new("\U0001F1F5\U0001F1F8");

        /// <summary>
        /// 🇵🇹 - REGIONAL INDICATOR SYMBOL LETTER P And REGIONAL INDICATOR SYMBOL LETTER T
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterPAndRegionalIndicatorSymbolLetterT = new("\U0001F1F5\U0001F1F9");

        /// <summary>
        /// 🇵🇼 - REGIONAL INDICATOR SYMBOL LETTER P And REGIONAL INDICATOR SYMBOL LETTER W
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterPAndRegionalIndicatorSymbolLetterW = new("\U0001F1F5\U0001F1FC");

        /// <summary>
        /// 🇵🇾 - REGIONAL INDICATOR SYMBOL LETTER P And REGIONAL INDICATOR SYMBOL LETTER Y
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterPAndRegionalIndicatorSymbolLetterY = new("\U0001F1F5\U0001F1FE");

        /// <summary>
        /// 🇶🇦 - REGIONAL INDICATOR SYMBOL LETTER Q And REGIONAL INDICATOR SYMBOL LETTER A
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterQAndRegionalIndicatorSymbolLetterA = new("\U0001F1F6\U0001F1E6");

        /// <summary>
        /// 🇷🇪 - REGIONAL INDICATOR SYMBOL LETTER R And REGIONAL INDICATOR SYMBOL LETTER E
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterRAndRegionalIndicatorSymbolLetterE = new("\U0001F1F7\U0001F1EA");

        /// <summary>
        /// 🇷🇴 - REGIONAL INDICATOR SYMBOL LETTER R And REGIONAL INDICATOR SYMBOL LETTER O
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterRAndRegionalIndicatorSymbolLetterO = new("\U0001F1F7\U0001F1F4");

        /// <summary>
        /// 🇷🇸 - REGIONAL INDICATOR SYMBOL LETTER R And REGIONAL INDICATOR SYMBOL LETTER S
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterRAndRegionalIndicatorSymbolLetterS = new("\U0001F1F7\U0001F1F8");

        /// <summary>
        /// 🇷🇺 - REGIONAL INDICATOR SYMBOL LETTER R And REGIONAL INDICATOR SYMBOL LETTER U
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterRAndRegionalIndicatorSymbolLetterU = new("\U0001F1F7\U0001F1FA");

        /// <summary>
        /// 🇷🇼 - REGIONAL INDICATOR SYMBOL LETTER R And REGIONAL INDICATOR SYMBOL LETTER W
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterRAndRegionalIndicatorSymbolLetterW = new("\U0001F1F7\U0001F1FC");

        /// <summary>
        /// 🇸🇦 - REGIONAL INDICATOR SYMBOL LETTER S And REGIONAL INDICATOR SYMBOL LETTER A
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterSAndRegionalIndicatorSymbolLetterA = new("\U0001F1F8\U0001F1E6");

        /// <summary>
        /// 🇸🇧 - REGIONAL INDICATOR SYMBOL LETTER S And REGIONAL INDICATOR SYMBOL LETTER B
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterSAndRegionalIndicatorSymbolLetterB = new("\U0001F1F8\U0001F1E7");

        /// <summary>
        /// 🇸🇨 - REGIONAL INDICATOR SYMBOL LETTER S And REGIONAL INDICATOR SYMBOL LETTER C
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterSAndRegionalIndicatorSymbolLetterC = new("\U0001F1F8\U0001F1E8");

        /// <summary>
        /// 🇸🇩 - REGIONAL INDICATOR SYMBOL LETTER S And REGIONAL INDICATOR SYMBOL LETTER D
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterSAndRegionalIndicatorSymbolLetterD = new("\U0001F1F8\U0001F1E9");

        /// <summary>
        /// 🇸🇪 - REGIONAL INDICATOR SYMBOL LETTER S And REGIONAL INDICATOR SYMBOL LETTER E
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterSAndRegionalIndicatorSymbolLetterE = new("\U0001F1F8\U0001F1EA");

        /// <summary>
        /// 🇸🇬 - REGIONAL INDICATOR SYMBOL LETTER S And REGIONAL INDICATOR SYMBOL LETTER G
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterSAndRegionalIndicatorSymbolLetterG = new("\U0001F1F8\U0001F1EC");

        /// <summary>
        /// 🇸🇭 - REGIONAL INDICATOR SYMBOL LETTER S And REGIONAL INDICATOR SYMBOL LETTER H
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterSAndRegionalIndicatorSymbolLetterH = new("\U0001F1F8\U0001F1ED");

        /// <summary>
        /// 🇸🇮 - REGIONAL INDICATOR SYMBOL LETTER S And REGIONAL INDICATOR SYMBOL LETTER I
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterSAndRegionalIndicatorSymbolLetterI = new("\U0001F1F8\U0001F1EE");

        /// <summary>
        /// 🇸🇯 - REGIONAL INDICATOR SYMBOL LETTER S And REGIONAL INDICATOR SYMBOL LETTER J
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterSAndRegionalIndicatorSymbolLetterJ = new("\U0001F1F8\U0001F1EF");

        /// <summary>
        /// 🇸🇰 - REGIONAL INDICATOR SYMBOL LETTER S And REGIONAL INDICATOR SYMBOL LETTER K
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterSAndRegionalIndicatorSymbolLetterK = new("\U0001F1F8\U0001F1F0");

        /// <summary>
        /// 🇸🇱 - REGIONAL INDICATOR SYMBOL LETTER S And REGIONAL INDICATOR SYMBOL LETTER L
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterSAndRegionalIndicatorSymbolLetterL = new("\U0001F1F8\U0001F1F1");

        /// <summary>
        /// 🇸🇲 - REGIONAL INDICATOR SYMBOL LETTER S And REGIONAL INDICATOR SYMBOL LETTER M
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterSAndRegionalIndicatorSymbolLetterM = new("\U0001F1F8\U0001F1F2");

        /// <summary>
        /// 🇸🇳 - REGIONAL INDICATOR SYMBOL LETTER S And REGIONAL INDICATOR SYMBOL LETTER N
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterSAndRegionalIndicatorSymbolLetterN = new("\U0001F1F8\U0001F1F3");

        /// <summary>
        /// 🇸🇴 - REGIONAL INDICATOR SYMBOL LETTER S And REGIONAL INDICATOR SYMBOL LETTER O
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterSAndRegionalIndicatorSymbolLetterO = new("\U0001F1F8\U0001F1F4");

        /// <summary>
        /// 🇸🇷 - REGIONAL INDICATOR SYMBOL LETTER S And REGIONAL INDICATOR SYMBOL LETTER R
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterSAndRegionalIndicatorSymbolLetterR = new("\U0001F1F8\U0001F1F7");

        /// <summary>
        /// 🇸🇸 - REGIONAL INDICATOR SYMBOL LETTER S And REGIONAL INDICATOR SYMBOL LETTER S
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterSAndRegionalIndicatorSymbolLetterS = new("\U0001F1F8\U0001F1F8");

        /// <summary>
        /// 🇸🇹 - REGIONAL INDICATOR SYMBOL LETTER S And REGIONAL INDICATOR SYMBOL LETTER T
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterSAndRegionalIndicatorSymbolLetterT = new("\U0001F1F8\U0001F1F9");

        /// <summary>
        /// 🇸🇻 - REGIONAL INDICATOR SYMBOL LETTER S And REGIONAL INDICATOR SYMBOL LETTER V
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterSAndRegionalIndicatorSymbolLetterV = new("\U0001F1F8\U0001F1FB");

        /// <summary>
        /// 🇸🇽 - REGIONAL INDICATOR SYMBOL LETTER S And REGIONAL INDICATOR SYMBOL LETTER X
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterSAndRegionalIndicatorSymbolLetterX = new("\U0001F1F8\U0001F1FD");

        /// <summary>
        /// 🇸🇾 - REGIONAL INDICATOR SYMBOL LETTER S And REGIONAL INDICATOR SYMBOL LETTER Y
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterSAndRegionalIndicatorSymbolLetterY = new("\U0001F1F8\U0001F1FE");

        /// <summary>
        /// 🇸🇿 - REGIONAL INDICATOR SYMBOL LETTER S And REGIONAL INDICATOR SYMBOL LETTER Z
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterSAndRegionalIndicatorSymbolLetterZ = new("\U0001F1F8\U0001F1FF");

        /// <summary>
        /// 🇹🇦 - REGIONAL INDICATOR SYMBOL LETTER T And REGIONAL INDICATOR SYMBOL LETTER A
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterTAndRegionalIndicatorSymbolLetterA = new("\U0001F1F9\U0001F1E6");

        /// <summary>
        /// 🇹🇨 - REGIONAL INDICATOR SYMBOL LETTER T And REGIONAL INDICATOR SYMBOL LETTER C
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterTAndRegionalIndicatorSymbolLetterC = new("\U0001F1F9\U0001F1E8");

        /// <summary>
        /// 🇹🇩 - REGIONAL INDICATOR SYMBOL LETTER T And REGIONAL INDICATOR SYMBOL LETTER D
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterTAndRegionalIndicatorSymbolLetterD = new("\U0001F1F9\U0001F1E9");

        /// <summary>
        /// 🇹🇫 - REGIONAL INDICATOR SYMBOL LETTER T And REGIONAL INDICATOR SYMBOL LETTER F
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterTAndRegionalIndicatorSymbolLetterF = new("\U0001F1F9\U0001F1EB");

        /// <summary>
        /// 🇹🇬 - REGIONAL INDICATOR SYMBOL LETTER T And REGIONAL INDICATOR SYMBOL LETTER G
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterTAndRegionalIndicatorSymbolLetterG = new("\U0001F1F9\U0001F1EC");

        /// <summary>
        /// 🇹🇭 - REGIONAL INDICATOR SYMBOL LETTER T And REGIONAL INDICATOR SYMBOL LETTER H
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterTAndRegionalIndicatorSymbolLetterH = new("\U0001F1F9\U0001F1ED");

        /// <summary>
        /// 🇹🇯 - REGIONAL INDICATOR SYMBOL LETTER T And REGIONAL INDICATOR SYMBOL LETTER J
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterTAndRegionalIndicatorSymbolLetterJ = new("\U0001F1F9\U0001F1EF");

        /// <summary>
        /// 🇹🇰 - REGIONAL INDICATOR SYMBOL LETTER T And REGIONAL INDICATOR SYMBOL LETTER K
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterTAndRegionalIndicatorSymbolLetterK = new("\U0001F1F9\U0001F1F0");

        /// <summary>
        /// 🇹🇱 - REGIONAL INDICATOR SYMBOL LETTER T And REGIONAL INDICATOR SYMBOL LETTER L
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterTAndRegionalIndicatorSymbolLetterL = new("\U0001F1F9\U0001F1F1");

        /// <summary>
        /// 🇹🇲 - REGIONAL INDICATOR SYMBOL LETTER T And REGIONAL INDICATOR SYMBOL LETTER M
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterTAndRegionalIndicatorSymbolLetterM = new("\U0001F1F9\U0001F1F2");

        /// <summary>
        /// 🇹🇳 - REGIONAL INDICATOR SYMBOL LETTER T And REGIONAL INDICATOR SYMBOL LETTER N
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterTAndRegionalIndicatorSymbolLetterN = new("\U0001F1F9\U0001F1F3");

        /// <summary>
        /// 🇹🇴 - REGIONAL INDICATOR SYMBOL LETTER T And REGIONAL INDICATOR SYMBOL LETTER O
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterTAndRegionalIndicatorSymbolLetterO = new("\U0001F1F9\U0001F1F4");

        /// <summary>
        /// 🇹🇷 - REGIONAL INDICATOR SYMBOL LETTER T And REGIONAL INDICATOR SYMBOL LETTER R
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterTAndRegionalIndicatorSymbolLetterR = new("\U0001F1F9\U0001F1F7");

        /// <summary>
        /// 🇹🇹 - REGIONAL INDICATOR SYMBOL LETTER T And REGIONAL INDICATOR SYMBOL LETTER T
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterTAndRegionalIndicatorSymbolLetterT = new("\U0001F1F9\U0001F1F9");

        /// <summary>
        /// 🇹🇻 - REGIONAL INDICATOR SYMBOL LETTER T And REGIONAL INDICATOR SYMBOL LETTER V
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterTAndRegionalIndicatorSymbolLetterV = new("\U0001F1F9\U0001F1FB");

        /// <summary>
        /// 🇹🇼 - REGIONAL INDICATOR SYMBOL LETTER T And REGIONAL INDICATOR SYMBOL LETTER W
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterTAndRegionalIndicatorSymbolLetterW = new("\U0001F1F9\U0001F1FC");

        /// <summary>
        /// 🇹🇿 - REGIONAL INDICATOR SYMBOL LETTER T And REGIONAL INDICATOR SYMBOL LETTER Z
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterTAndRegionalIndicatorSymbolLetterZ = new("\U0001F1F9\U0001F1FF");

        /// <summary>
        /// 🇺🇦 - REGIONAL INDICATOR SYMBOL LETTER U And REGIONAL INDICATOR SYMBOL LETTER A
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterUAndRegionalIndicatorSymbolLetterA = new("\U0001F1FA\U0001F1E6");

        /// <summary>
        /// 🇺🇬 - REGIONAL INDICATOR SYMBOL LETTER U And REGIONAL INDICATOR SYMBOL LETTER G
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterUAndRegionalIndicatorSymbolLetterG = new("\U0001F1FA\U0001F1EC");

        /// <summary>
        /// 🇺🇲 - REGIONAL INDICATOR SYMBOL LETTER U And REGIONAL INDICATOR SYMBOL LETTER M
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterUAndRegionalIndicatorSymbolLetterM = new("\U0001F1FA\U0001F1F2");

        /// <summary>
        /// 🇺🇸 - REGIONAL INDICATOR SYMBOL LETTER U And REGIONAL INDICATOR SYMBOL LETTER S
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterUAndRegionalIndicatorSymbolLetterS = new("\U0001F1FA\U0001F1F8");

        /// <summary>
        /// 🇺🇾 - REGIONAL INDICATOR SYMBOL LETTER U And REGIONAL INDICATOR SYMBOL LETTER Y
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterUAndRegionalIndicatorSymbolLetterY = new("\U0001F1FA\U0001F1FE");

        /// <summary>
        /// 🇺🇿 - REGIONAL INDICATOR SYMBOL LETTER U And REGIONAL INDICATOR SYMBOL LETTER Z
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterUAndRegionalIndicatorSymbolLetterZ = new("\U0001F1FA\U0001F1FF");

        /// <summary>
        /// 🇻🇦 - REGIONAL INDICATOR SYMBOL LETTER V And REGIONAL INDICATOR SYMBOL LETTER A
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterVAndRegionalIndicatorSymbolLetterA = new("\U0001F1FB\U0001F1E6");

        /// <summary>
        /// 🇻🇨 - REGIONAL INDICATOR SYMBOL LETTER V And REGIONAL INDICATOR SYMBOL LETTER C
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterVAndRegionalIndicatorSymbolLetterC = new("\U0001F1FB\U0001F1E8");

        /// <summary>
        /// 🇻🇪 - REGIONAL INDICATOR SYMBOL LETTER V And REGIONAL INDICATOR SYMBOL LETTER E
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterVAndRegionalIndicatorSymbolLetterE = new("\U0001F1FB\U0001F1EA");

        /// <summary>
        /// 🇻🇬 - REGIONAL INDICATOR SYMBOL LETTER V And REGIONAL INDICATOR SYMBOL LETTER G
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterVAndRegionalIndicatorSymbolLetterG = new("\U0001F1FB\U0001F1EC");

        /// <summary>
        /// 🇻🇮 - REGIONAL INDICATOR SYMBOL LETTER V And REGIONAL INDICATOR SYMBOL LETTER I
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterVAndRegionalIndicatorSymbolLetterI = new("\U0001F1FB\U0001F1EE");

        /// <summary>
        /// 🇻🇳 - REGIONAL INDICATOR SYMBOL LETTER V And REGIONAL INDICATOR SYMBOL LETTER N
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterVAndRegionalIndicatorSymbolLetterN = new("\U0001F1FB\U0001F1F3");

        /// <summary>
        /// 🇻🇺 - REGIONAL INDICATOR SYMBOL LETTER V And REGIONAL INDICATOR SYMBOL LETTER U
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterVAndRegionalIndicatorSymbolLetterU = new("\U0001F1FB\U0001F1FA");

        /// <summary>
        /// 🇼🇫 - REGIONAL INDICATOR SYMBOL LETTER W And REGIONAL INDICATOR SYMBOL LETTER F
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterWAndRegionalIndicatorSymbolLetterF = new("\U0001F1FC\U0001F1EB");

        /// <summary>
        /// 🇼🇸 - REGIONAL INDICATOR SYMBOL LETTER W And REGIONAL INDICATOR SYMBOL LETTER S
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterWAndRegionalIndicatorSymbolLetterS = new("\U0001F1FC\U0001F1F8");

        /// <summary>
        /// 🇽🇰 - REGIONAL INDICATOR SYMBOL LETTER X And REGIONAL INDICATOR SYMBOL LETTER K
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterXAndRegionalIndicatorSymbolLetterK = new("\U0001F1FD\U0001F1F0");

        /// <summary>
        /// 🇾🇪 - REGIONAL INDICATOR SYMBOL LETTER Y And REGIONAL INDICATOR SYMBOL LETTER E
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterYAndRegionalIndicatorSymbolLetterE = new("\U0001F1FE\U0001F1EA");

        /// <summary>
        /// 🇾🇹 - REGIONAL INDICATOR SYMBOL LETTER Y And REGIONAL INDICATOR SYMBOL LETTER T
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterYAndRegionalIndicatorSymbolLetterT = new("\U0001F1FE\U0001F1F9");

        /// <summary>
        /// 🇿🇦 - REGIONAL INDICATOR SYMBOL LETTER Z And REGIONAL INDICATOR SYMBOL LETTER A
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterZAndRegionalIndicatorSymbolLetterA = new("\U0001F1FF\U0001F1E6");

        /// <summary>
        /// 🇿🇲 - REGIONAL INDICATOR SYMBOL LETTER Z And REGIONAL INDICATOR SYMBOL LETTER M
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterZAndRegionalIndicatorSymbolLetterM = new("\U0001F1FF\U0001F1F2");

        /// <summary>
        /// 🇿🇼 - REGIONAL INDICATOR SYMBOL LETTER Z And REGIONAL INDICATOR SYMBOL LETTER W
        /// </summary>
        public static readonly Emoji RegionalIndicatorSymbolLetterZAndRegionalIndicatorSymbolLetterW = new("\U0001F1FF\U0001F1FC");
    }
}
