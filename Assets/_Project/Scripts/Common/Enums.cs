

public enum eCardType
{
    active,
    weapon,
    equip,
    debuff
}


public enum eCharacterType
{
    playable,
    non_playable,
    npc
}

public enum eRoleType
{
    none,
    target,
    bodyguard,
    hitman,
    psychopass,
}
public enum eCharacterState
{
    NONE = 0,
    BBANG_SHOOTER = 1, // ���� ������
    BBANG_TARGET = 2, // ���� ��� (���� ��밡�� ����)
    DEATH_MATCH = 3, // ���� �� �ڽ��� ���� �ƴ� ��
    DEATH_MATCH_TURN = 4, // ���� �� �ڽ��� ��
    FLEA_MARKET_TURN = 5, // �ø����� �ڽ��� ��
    FLEA_MARKET_WAIT = 6, // �ø����� �� ��� ����
    GUERRILLA_SHOOTER = 7, // �Ը��� ������
    GUERRILLA_TARGET = 8, // �Ը��� ���
    BIG_BBANG_SHOOTER = 9, // ���� ������
    BIG_BBANG_TARGET = 10, // ���� ���
    ABSORBING = 11, // ��� ��
    ABSORB_TARGET = 12, // ��� ���
    HALLUCINATING = 13, // �ű�� ��
    HALLUCINATION_TARGET = 14, // �ű�� ���
    CONTAINED = 15, // ���� ��
}