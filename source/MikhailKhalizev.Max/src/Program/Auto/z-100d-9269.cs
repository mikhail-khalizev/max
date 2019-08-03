using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("4e611de2-2848-4a2b-8c36-2ddc6eea71a3")]
        public void Method_100d_9269()
        {
            ii(0x100d_9269, 5); pushd(0x8c);                            /* push 0x8c */
            ii(0x100d_926e, 5); calld(Definitions.sys_check_available_stack_size, 0x8cadf); /* call 0x10165d52 */
            ii(0x100d_9273, 1); pushd(ebx);                             /* push ebx */
            ii(0x100d_9274, 1); pushd(ecx);                             /* push ecx */
            ii(0x100d_9275, 1); pushd(edx);                             /* push edx */
            ii(0x100d_9276, 1); pushd(esi);                             /* push esi */
            ii(0x100d_9277, 1); pushd(edi);                             /* push edi */
            ii(0x100d_9278, 1); pushd(ebp);                             /* push ebp */
            ii(0x100d_9279, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100d_927b, 6); sub(esp, 0x60);                         /* sub esp, 0x60 */
            ii(0x100d_9281, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100d_9284, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_9287, 7); cmp(memd_a32[ds, eax + 0x39f], 0);      /* cmp dword [eax+0x39f], 0x0 */
            ii(0x100d_928e, 2); if(jzd(0x100d_9299, 0x9)) goto l_0x100d_9299; /* jz 0x100d9299 */
            ii(0x100d_9290, 7); mov(memd_a32[ss, ebp - 0x60], 0);       /* mov dword [ebp-0x60], 0x0 */
            ii(0x100d_9297, 2); jmpd(0x100d_92b2, 0x19); goto l_0x100d_92b2; /* jmp 0x100d92b2 */
        l_0x100d_9299:
            ii(0x100d_9299, 5); mov(ecx, 0x431);                        /* mov ecx, 0x431 */
            ii(0x100d_929e, 5); mov(ebx, 0x101a_1827);                  /* mov ebx, 0x101a1827 */ /* "commo.cpp" */
            ii(0x100d_92a3, 5); mov(edx, 0x101a_1831);                  /* mov edx, 0x101a1831 */ /* "stats_background != 0" */
            ii(0x100d_92a8, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100d_92aa, 5); calld(Definitions.sys_assert, 0x8cae3); /* call 0x10165d92 */
            ii(0x100d_92af, 3); mov(memd_a32[ss, ebp - 0x60], eax);     /* mov [ebp-0x60], eax */
        l_0x100d_92b2:
            ii(0x100d_92b2, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_92b5, 7); cmp(memd_a32[ds, eax + 0x3a3], 0);      /* cmp dword [eax+0x3a3], 0x0 */
            ii(0x100d_92bc, 2); if(jzd(0x100d_92c7, 0x9)) goto l_0x100d_92c7; /* jz 0x100d92c7 */
            ii(0x100d_92be, 7); mov(memd_a32[ss, ebp - 0x5c], 0);       /* mov dword [ebp-0x5c], 0x0 */
            ii(0x100d_92c5, 2); jmpd(0x100d_92e0, 0x19); goto l_0x100d_92e0; /* jmp 0x100d92e0 */
        l_0x100d_92c7:
            ii(0x100d_92c7, 5); mov(ecx, 0x432);                        /* mov ecx, 0x432 */
            ii(0x100d_92cc, 5); mov(ebx, 0x101a_1847);                  /* mov ebx, 0x101a1847 */ /* "commo.cpp" */
            ii(0x100d_92d1, 5); mov(edx, 0x101a_1851);                  /* mov edx, 0x101a1851 */ /* "cost_background != 0" */
            ii(0x100d_92d6, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100d_92d8, 5); calld(Definitions.sys_assert, 0x8cab5); /* call 0x10165d92 */
            ii(0x100d_92dd, 3); mov(memd_a32[ss, ebp - 0x5c], eax);     /* mov [ebp-0x5c], eax */
        l_0x100d_92e0:
            ii(0x100d_92e0, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_92e3, 7); cmp(memd_a32[ds, eax + 0x3a7], 0);      /* cmp dword [eax+0x3a7], 0x0 */
            ii(0x100d_92ea, 2); if(jzd(0x100d_92f5, 0x9)) goto l_0x100d_92f5; /* jz 0x100d92f5 */
            ii(0x100d_92ec, 7); mov(memd_a32[ss, ebp - 0x58], 0);       /* mov dword [ebp-0x58], 0x0 */
            ii(0x100d_92f3, 2); jmpd(0x100d_930e, 0x19); goto l_0x100d_930e; /* jmp 0x100d930e */
        l_0x100d_92f5:
            ii(0x100d_92f5, 5); mov(ecx, 0x433);                        /* mov ecx, 0x433 */
            ii(0x100d_92fa, 5); mov(ebx, 0x101a_1866);                  /* mov ebx, 0x101a1866 */ /* "commo.cpp" */
            ii(0x100d_92ff, 5); mov(edx, 0x101a_1870);                  /* mov edx, 0x101a1870 */ /* "gold_background != 0" */
            ii(0x100d_9304, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100d_9306, 5); calld(Definitions.sys_assert, 0x8ca87); /* call 0x10165d92 */
            ii(0x100d_930b, 3); mov(memd_a32[ss, ebp - 0x58], eax);     /* mov [ebp-0x58], eax */
        l_0x100d_930e:
            ii(0x100d_930e, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_9311, 7); cmp(memd_a32[ds, eax + 0x3ab], 0);      /* cmp dword [eax+0x3ab], 0x0 */
            ii(0x100d_9318, 2); if(jzd(0x100d_9323, 0x9)) goto l_0x100d_9323; /* jz 0x100d9323 */
            ii(0x100d_931a, 7); mov(memd_a32[ss, ebp - 0x54], 0);       /* mov dword [ebp-0x54], 0x0 */
            ii(0x100d_9321, 2); jmpd(0x100d_933c, 0x19); goto l_0x100d_933c; /* jmp 0x100d933c */
        l_0x100d_9323:
            ii(0x100d_9323, 5); mov(ecx, 0x434);                        /* mov ecx, 0x434 */
            ii(0x100d_9328, 5); mov(ebx, 0x101a_1885);                  /* mov ebx, 0x101a1885 */ /* "commo.cpp" */
            ii(0x100d_932d, 5); mov(edx, 0x101a_188f);                  /* mov edx, 0x101a188f */ /* "button_background != 0" */
            ii(0x100d_9332, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100d_9334, 5); calld(Definitions.sys_assert, 0x8ca59); /* call 0x10165d92 */
            ii(0x100d_9339, 3); mov(memd_a32[ss, ebp - 0x54], eax);     /* mov [ebp-0x54], eax */
        l_0x100d_933c:
            ii(0x100d_933c, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_933f, 7); cmp(memd_a32[ds, eax + 0x349], 0);      /* cmp dword [eax+0x349], 0x0 */
            ii(0x100d_9346, 2); if(jzd(0x100d_9351, 0x9)) goto l_0x100d_9351; /* jz 0x100d9351 */
            ii(0x100d_9348, 7); mov(memd_a32[ss, ebp - 0x50], 0);       /* mov dword [ebp-0x50], 0x0 */
            ii(0x100d_934f, 2); jmpd(0x100d_936a, 0x19); goto l_0x100d_936a; /* jmp 0x100d936a */
        l_0x100d_9351:
            ii(0x100d_9351, 5); mov(ecx, 0x435);                        /* mov ecx, 0x435 */
            ii(0x100d_9356, 5); mov(ebx, 0x101a_18a6);                  /* mov ebx, 0x101a18a6 */ /* "commo.cpp" */
            ii(0x100d_935b, 5); mov(edx, 0x101a_18b0);                  /* mov edx, 0x101a18b0 */ /* "scroll_up != 0" */
            ii(0x100d_9360, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100d_9362, 5); calld(Definitions.sys_assert, 0x8ca2b); /* call 0x10165d92 */
            ii(0x100d_9367, 3); mov(memd_a32[ss, ebp - 0x50], eax);     /* mov [ebp-0x50], eax */
        l_0x100d_936a:
            ii(0x100d_936a, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_936d, 7); cmp(memd_a32[ds, eax + 0x34d], 0);      /* cmp dword [eax+0x34d], 0x0 */
            ii(0x100d_9374, 2); if(jzd(0x100d_937f, 0x9)) goto l_0x100d_937f; /* jz 0x100d937f */
            ii(0x100d_9376, 7); mov(memd_a32[ss, ebp - 0x4c], 0);       /* mov dword [ebp-0x4c], 0x0 */
            ii(0x100d_937d, 2); jmpd(0x100d_9398, 0x19); goto l_0x100d_9398; /* jmp 0x100d9398 */
        l_0x100d_937f:
            ii(0x100d_937f, 5); mov(ecx, 0x436);                        /* mov ecx, 0x436 */
            ii(0x100d_9384, 5); mov(ebx, 0x101a_18bf);                  /* mov ebx, 0x101a18bf */ /* "commo.cpp" */
            ii(0x100d_9389, 5); mov(edx, 0x101a_18c9);                  /* mov edx, 0x101a18c9 */ /* "scroll_down != 0" */
            ii(0x100d_938e, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100d_9390, 5); calld(Definitions.sys_assert, 0x8c9fd); /* call 0x10165d92 */
            ii(0x100d_9395, 3); mov(memd_a32[ss, ebp - 0x4c], eax);     /* mov [ebp-0x4c], eax */
        l_0x100d_9398:
            ii(0x100d_9398, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_939b, 7); cmp(memd_a32[ds, eax + 0x351], 0);      /* cmp dword [eax+0x351], 0x0 */
            ii(0x100d_93a2, 2); if(jzd(0x100d_93ad, 0x9)) goto l_0x100d_93ad; /* jz 0x100d93ad */
            ii(0x100d_93a4, 7); mov(memd_a32[ss, ebp - 0x48], 0);       /* mov dword [ebp-0x48], 0x0 */
            ii(0x100d_93ab, 2); jmpd(0x100d_93c6, 0x19); goto l_0x100d_93c6; /* jmp 0x100d93c6 */
        l_0x100d_93ad:
            ii(0x100d_93ad, 5); mov(ecx, 0x437);                        /* mov ecx, 0x437 */
            ii(0x100d_93b2, 5); mov(ebx, 0x101a_18da);                  /* mov ebx, 0x101a18da */ /* "commo.cpp" */
            ii(0x100d_93b7, 5); mov(edx, 0x101a_18e4);                  /* mov edx, 0x101a18e4 */ /* "done_button != 0" */
            ii(0x100d_93bc, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100d_93be, 5); calld(Definitions.sys_assert, 0x8c9cf); /* call 0x10165d92 */
            ii(0x100d_93c3, 3); mov(memd_a32[ss, ebp - 0x48], eax);     /* mov [ebp-0x48], eax */
        l_0x100d_93c6:
            ii(0x100d_93c6, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_93c9, 7); cmp(memd_a32[ds, eax + 0x355], 0);      /* cmp dword [eax+0x355], 0x0 */
            ii(0x100d_93d0, 2); if(jzd(0x100d_93db, 0x9)) goto l_0x100d_93db; /* jz 0x100d93db */
            ii(0x100d_93d2, 7); mov(memd_a32[ss, ebp - 0x44], 0);       /* mov dword [ebp-0x44], 0x0 */
            ii(0x100d_93d9, 2); jmpd(0x100d_93f4, 0x19); goto l_0x100d_93f4; /* jmp 0x100d93f4 */
        l_0x100d_93db:
            ii(0x100d_93db, 5); mov(ecx, 0x438);                        /* mov ecx, 0x438 */
            ii(0x100d_93e0, 5); mov(ebx, 0x101a_18f5);                  /* mov ebx, 0x101a18f5 */ /* "commo.cpp" */
            ii(0x100d_93e5, 5); mov(edx, 0x101a_18ff);                  /* mov edx, 0x101a18ff */ /* "help_button != 0" */
            ii(0x100d_93ea, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100d_93ec, 5); calld(Definitions.sys_assert, 0x8c9a1); /* call 0x10165d92 */
            ii(0x100d_93f1, 3); mov(memd_a32[ss, ebp - 0x44], eax);     /* mov [ebp-0x44], eax */
        l_0x100d_93f4:
            ii(0x100d_93f4, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_93f7, 7); cmp(memd_a32[ds, eax + 0x359], 0);      /* cmp dword [eax+0x359], 0x0 */
            ii(0x100d_93fe, 2); if(jzd(0x100d_9409, 0x9)) goto l_0x100d_9409; /* jz 0x100d9409 */
            ii(0x100d_9400, 7); mov(memd_a32[ss, ebp - 0x40], 0);       /* mov dword [ebp-0x40], 0x0 */
            ii(0x100d_9407, 2); jmpd(0x100d_9422, 0x19); goto l_0x100d_9422; /* jmp 0x100d9422 */
        l_0x100d_9409:
            ii(0x100d_9409, 5); mov(ecx, 0x439);                        /* mov ecx, 0x439 */
            ii(0x100d_940e, 5); mov(ebx, 0x101a_1910);                  /* mov ebx, 0x101a1910 */ /* "commo.cpp" */
            ii(0x100d_9413, 5); mov(edx, 0x101a_191a);                  /* mov edx, 0x101a191a */ /* "cancel_button != 0" */
            ii(0x100d_9418, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100d_941a, 5); calld(Definitions.sys_assert, 0x8c973); /* call 0x10165d92 */
            ii(0x100d_941f, 3); mov(memd_a32[ss, ebp - 0x40], eax);     /* mov [ebp-0x40], eax */
        l_0x100d_9422:
            ii(0x100d_9422, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_9425, 7); cmp(memd_a32[ds, eax + 0x35d], 0);      /* cmp dword [eax+0x35d], 0x0 */
            ii(0x100d_942c, 2); if(jzd(0x100d_9437, 0x9)) goto l_0x100d_9437; /* jz 0x100d9437 */
            ii(0x100d_942e, 7); mov(memd_a32[ss, ebp - 0x3c], 0);       /* mov dword [ebp-0x3c], 0x0 */
            ii(0x100d_9435, 2); jmpd(0x100d_9450, 0x19); goto l_0x100d_9450; /* jmp 0x100d9450 */
        l_0x100d_9437:
            ii(0x100d_9437, 5); mov(ecx, 0x43a);                        /* mov ecx, 0x43a */
            ii(0x100d_943c, 5); mov(ebx, 0x101a_192d);                  /* mov ebx, 0x101a192d */ /* "commo.cpp" */
            ii(0x100d_9441, 5); mov(edx, 0x101a_1937);                  /* mov edx, 0x101a1937 */ /* "ground_button != 0" */
            ii(0x100d_9446, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100d_9448, 5); calld(Definitions.sys_assert, 0x8c945); /* call 0x10165d92 */
            ii(0x100d_944d, 3); mov(memd_a32[ss, ebp - 0x3c], eax);     /* mov [ebp-0x3c], eax */
        l_0x100d_9450:
            ii(0x100d_9450, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_9453, 7); cmp(memd_a32[ds, eax + 0x361], 0);      /* cmp dword [eax+0x361], 0x0 */
            ii(0x100d_945a, 2); if(jzd(0x100d_9465, 0x9)) goto l_0x100d_9465; /* jz 0x100d9465 */
            ii(0x100d_945c, 7); mov(memd_a32[ss, ebp - 0x38], 0);       /* mov dword [ebp-0x38], 0x0 */
            ii(0x100d_9463, 2); jmpd(0x100d_947e, 0x19); goto l_0x100d_947e; /* jmp 0x100d947e */
        l_0x100d_9465:
            ii(0x100d_9465, 5); mov(ecx, 0x43b);                        /* mov ecx, 0x43b */
            ii(0x100d_946a, 5); mov(ebx, 0x101a_194a);                  /* mov ebx, 0x101a194a */ /* "commo.cpp" */
            ii(0x100d_946f, 5); mov(edx, 0x101a_1954);                  /* mov edx, 0x101a1954 */ /* "air_button != 0" */
            ii(0x100d_9474, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100d_9476, 5); calld(Definitions.sys_assert, 0x8c917); /* call 0x10165d92 */
            ii(0x100d_947b, 3); mov(memd_a32[ss, ebp - 0x38], eax);     /* mov [ebp-0x38], eax */
        l_0x100d_947e:
            ii(0x100d_947e, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_9481, 7); cmp(memd_a32[ds, eax + 0x365], 0);      /* cmp dword [eax+0x365], 0x0 */
            ii(0x100d_9488, 2); if(jzd(0x100d_9493, 0x9)) goto l_0x100d_9493; /* jz 0x100d9493 */
            ii(0x100d_948a, 7); mov(memd_a32[ss, ebp - 0x34], 0);       /* mov dword [ebp-0x34], 0x0 */
            ii(0x100d_9491, 2); jmpd(0x100d_94ac, 0x19); goto l_0x100d_94ac; /* jmp 0x100d94ac */
        l_0x100d_9493:
            ii(0x100d_9493, 5); mov(ecx, 0x43c);                        /* mov ecx, 0x43c */
            ii(0x100d_9498, 5); mov(ebx, 0x101a_1964);                  /* mov ebx, 0x101a1964 */ /* "commo.cpp" */
            ii(0x100d_949d, 5); mov(edx, 0x101a_196e);                  /* mov edx, 0x101a196e */ /* "sea_button != 0" */
            ii(0x100d_94a2, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100d_94a4, 5); calld(Definitions.sys_assert, 0x8c8e9); /* call 0x10165d92 */
            ii(0x100d_94a9, 3); mov(memd_a32[ss, ebp - 0x34], eax);     /* mov [ebp-0x34], eax */
        l_0x100d_94ac:
            ii(0x100d_94ac, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_94af, 7); cmp(memd_a32[ds, eax + 0x369], 0);      /* cmp dword [eax+0x369], 0x0 */
            ii(0x100d_94b6, 2); if(jzd(0x100d_94c1, 0x9)) goto l_0x100d_94c1; /* jz 0x100d94c1 */
            ii(0x100d_94b8, 7); mov(memd_a32[ss, ebp - 0x30], 0);       /* mov dword [ebp-0x30], 0x0 */
            ii(0x100d_94bf, 2); jmpd(0x100d_94da, 0x19); goto l_0x100d_94da; /* jmp 0x100d94da */
        l_0x100d_94c1:
            ii(0x100d_94c1, 5); mov(ecx, 0x43d);                        /* mov ecx, 0x43d */
            ii(0x100d_94c6, 5); mov(ebx, 0x101a_197e);                  /* mov ebx, 0x101a197e */ /* "commo.cpp" */
            ii(0x100d_94cb, 5); mov(edx, 0x101a_1988);                  /* mov edx, 0x101a1988 */ /* "building_button != 0" */
            ii(0x100d_94d0, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100d_94d2, 5); calld(Definitions.sys_assert, 0x8c8bb); /* call 0x10165d92 */
            ii(0x100d_94d7, 3); mov(memd_a32[ss, ebp - 0x30], eax);     /* mov [ebp-0x30], eax */
        l_0x100d_94da:
            ii(0x100d_94da, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_94dd, 7); cmp(memd_a32[ds, eax + 0x36d], 0);      /* cmp dword [eax+0x36d], 0x0 */
            ii(0x100d_94e4, 2); if(jzd(0x100d_94ef, 0x9)) goto l_0x100d_94ef; /* jz 0x100d94ef */
            ii(0x100d_94e6, 7); mov(memd_a32[ss, ebp - 0x2c], 0);       /* mov dword [ebp-0x2c], 0x0 */
            ii(0x100d_94ed, 2); jmpd(0x100d_9508, 0x19); goto l_0x100d_9508; /* jmp 0x100d9508 */
        l_0x100d_94ef:
            ii(0x100d_94ef, 5); mov(ecx, 0x43e);                        /* mov ecx, 0x43e */
            ii(0x100d_94f4, 5); mov(ebx, 0x101a_199d);                  /* mov ebx, 0x101a199d */ /* "commo.cpp" */
            ii(0x100d_94f9, 5); mov(edx, 0x101a_19a7);                  /* mov edx, 0x101a19a7 */ /* "combat_button != 0" */
            ii(0x100d_94fe, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100d_9500, 5); calld(Definitions.sys_assert, 0x8c88d); /* call 0x10165d92 */
            ii(0x100d_9505, 3); mov(memd_a32[ss, ebp - 0x2c], eax);     /* mov [ebp-0x2c], eax */
        l_0x100d_9508:
            ii(0x100d_9508, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_950b, 7); cmp(memd_a32[ds, eax + 0x371], 0);      /* cmp dword [eax+0x371], 0x0 */
            ii(0x100d_9512, 2); if(jzd(0x100d_951d, 0x9)) goto l_0x100d_951d; /* jz 0x100d951d */
            ii(0x100d_9514, 7); mov(memd_a32[ss, ebp - 0x28], 0);       /* mov dword [ebp-0x28], 0x0 */
            ii(0x100d_951b, 2); jmpd(0x100d_9536, 0x19); goto l_0x100d_9536; /* jmp 0x100d9536 */
        l_0x100d_951d:
            ii(0x100d_951d, 5); mov(ecx, 0x43f);                        /* mov ecx, 0x43f */
            ii(0x100d_9522, 5); mov(ebx, 0x101a_19ba);                  /* mov ebx, 0x101a19ba */ /* "commo.cpp" */
            ii(0x100d_9527, 5); mov(edx, 0x101a_19c4);                  /* mov edx, 0x101a19c4 */ /* "description_button != 0" */
            ii(0x100d_952c, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100d_952e, 5); calld(Definitions.sys_assert, 0x8c85f); /* call 0x10165d92 */
            ii(0x100d_9533, 3); mov(memd_a32[ss, ebp - 0x28], eax);     /* mov [ebp-0x28], eax */
        l_0x100d_9536:
            ii(0x100d_9536, 5); mov(edx, 0x11c);                        /* mov edx, 0x11c */
            ii(0x100d_953b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_953e, 6); mov(eax, memd_a32[ds, eax + 0x349]);    /* mov eax, [eax+0x349] */
            ii(0x100d_9544, 5); calld(0x100c_f2ba, -0xa28f);            /* call 0x100cf2ba */
            ii(0x100d_9549, 5); mov(edx, 0x11f);                        /* mov edx, 0x11f */
            ii(0x100d_954e, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_9551, 6); mov(eax, memd_a32[ds, eax + 0x34d]);    /* mov eax, [eax+0x34d] */
            ii(0x100d_9557, 5); calld(0x100c_f2ba, -0xa2a2);            /* call 0x100cf2ba */
            ii(0x100d_955c, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100d_955f, 5); calld(0x100d_5224, -0x4340);            /* call 0x100d5224 */
            ii(0x100d_9564, 1); pushd(eax);                             /* push eax */
            ii(0x100d_9565, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x100d_9568, 5); calld(0x100d_5250, -0x431d);            /* call 0x100d5250 */
            ii(0x100d_956d, 1); pushd(eax);                             /* push eax */
            ii(0x100d_956e, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x100d_9571, 5); calld(0x100d_527c, -0x42fa);            /* call 0x100d527c */
            ii(0x100d_9576, 1); pushd(eax);                             /* push eax */
            ii(0x100d_9577, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100d_957a, 5); calld(0x100d_52a8, -0x42d7);            /* call 0x100d52a8 */
            ii(0x100d_957f, 1); pushd(eax);                             /* push eax */
            ii(0x100d_9580, 5); calld(0x100d_52d4, -0x42b1);            /* call 0x100d52d4 */
            ii(0x100d_9585, 3); movsx(ecx, ax);                         /* movsx ecx, ax */
            ii(0x100d_9588, 5); calld(0x100d_52f8, -0x4295);            /* call 0x100d52f8 */
            ii(0x100d_958d, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x100d_9590, 5); mov(edx, 0x101a_19dc);                  /* mov edx, 0x101a19dc */ /* "Done" */
            ii(0x100d_9595, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_9598, 6); mov(eax, memd_a32[ds, eax + 0x351]);    /* mov eax, [eax+0x351] */
            ii(0x100d_959e, 5); calld(0x100c_ef64, -0xa63f);            /* call 0x100cef64 */
            ii(0x100d_95a3, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x100d_95a6, 5); calld(0x100d_5224, -0x4387);            /* call 0x100d5224 */
            ii(0x100d_95ab, 1); pushd(eax);                             /* push eax */
            ii(0x100d_95ac, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100d_95af, 5); calld(0x100d_5250, -0x4364);            /* call 0x100d5250 */
            ii(0x100d_95b4, 1); pushd(eax);                             /* push eax */
            ii(0x100d_95b5, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x100d_95b8, 5); calld(0x100d_527c, -0x4341);            /* call 0x100d527c */
            ii(0x100d_95bd, 1); pushd(eax);                             /* push eax */
            ii(0x100d_95be, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x100d_95c1, 5); calld(0x100d_52a8, -0x431e);            /* call 0x100d52a8 */
            ii(0x100d_95c6, 1); pushd(eax);                             /* push eax */
            ii(0x100d_95c7, 5); calld(0x100d_52d4, -0x42f8);            /* call 0x100d52d4 */
            ii(0x100d_95cc, 3); movsx(ecx, ax);                         /* movsx ecx, ax */
            ii(0x100d_95cf, 5); calld(0x100d_52f8, -0x42dc);            /* call 0x100d52f8 */
            ii(0x100d_95d4, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x100d_95d7, 5); mov(edx, 0x101a_19e1);                  /* mov edx, 0x101a19e1 */ /* "Cancel" */
            ii(0x100d_95dc, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_95df, 6); mov(eax, memd_a32[ds, eax + 0x359]);    /* mov eax, [eax+0x359] */
            ii(0x100d_95e5, 5); calld(0x100c_ef64, -0xa686);            /* call 0x100cef64 */
            ii(0x100d_95ea, 5); mov(edx, 0x3e8);                        /* mov edx, 0x3e8 */
            ii(0x100d_95ef, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_95f2, 6); mov(eax, memd_a32[ds, eax + 0x351]);    /* mov eax, [eax+0x351] */
            ii(0x100d_95f8, 5); calld(0x100d_5134, -0x44c9);            /* call 0x100d5134 */
            ii(0x100d_95fd, 5); mov(edx, 0x3e9);                        /* mov edx, 0x3e9 */
            ii(0x100d_9602, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_9605, 6); mov(eax, memd_a32[ds, eax + 0x355]);    /* mov eax, [eax+0x355] */
            ii(0x100d_960b, 5); calld(0x100d_5134, -0x44dc);            /* call 0x100d5134 */
            ii(0x100d_9610, 5); mov(edx, 0x3ea);                        /* mov edx, 0x3ea */
            ii(0x100d_9615, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_9618, 6); mov(eax, memd_a32[ds, eax + 0x359]);    /* mov eax, [eax+0x359] */
            ii(0x100d_961e, 5); calld(0x100d_5134, -0x44ef);            /* call 0x100d5134 */
            ii(0x100d_9623, 5); mov(edx, 0x73e8);                       /* mov edx, 0x73e8 */
            ii(0x100d_9628, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_962b, 6); mov(eax, memd_a32[ds, eax + 0x351]);    /* mov eax, [eax+0x351] */
            ii(0x100d_9631, 5); calld(0x100d_5164, -0x44d2);            /* call 0x100d5164 */
            ii(0x100d_9636, 5); mov(edx, 0x73e9);                       /* mov edx, 0x73e9 */
            ii(0x100d_963b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_963e, 6); mov(eax, memd_a32[ds, eax + 0x355]);    /* mov eax, [eax+0x355] */
            ii(0x100d_9644, 5); calld(0x100d_5164, -0x44e5);            /* call 0x100d5164 */
            ii(0x100d_9649, 5); mov(edx, 0x73ea);                       /* mov edx, 0x73ea */
            ii(0x100d_964e, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_9651, 6); mov(eax, memd_a32[ds, eax + 0x359]);    /* mov eax, [eax+0x359] */
            ii(0x100d_9657, 5); calld(0x100d_5164, -0x44f8);            /* call 0x100d5164 */
            ii(0x100d_965c, 5); mov(edx, 0x3eb);                        /* mov edx, 0x3eb */
            ii(0x100d_9661, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_9664, 6); mov(eax, memd_a32[ds, eax + 0x35d]);    /* mov eax, [eax+0x35d] */
            ii(0x100d_966a, 5); calld(0x100d_5164, -0x450b);            /* call 0x100d5164 */
            ii(0x100d_966f, 5); mov(edx, 0x3ec);                        /* mov edx, 0x3ec */
            ii(0x100d_9674, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_9677, 6); mov(eax, memd_a32[ds, eax + 0x35d]);    /* mov eax, [eax+0x35d] */
            ii(0x100d_967d, 5); calld(0x100d_5134, -0x454e);            /* call 0x100d5134 */
            ii(0x100d_9682, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x100d_9687, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_968a, 6); mov(eax, memd_a32[ds, eax + 0x35d]);    /* mov eax, [eax+0x35d] */
            ii(0x100d_9690, 5); calld(0x100d_5194, -0x4501);            /* call 0x100d5194 */
            ii(0x100d_9695, 5); mov(edx, 0x3ed);                        /* mov edx, 0x3ed */
            ii(0x100d_969a, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_969d, 6); mov(eax, memd_a32[ds, eax + 0x361]);    /* mov eax, [eax+0x361] */
            ii(0x100d_96a3, 5); calld(0x100d_5164, -0x4544);            /* call 0x100d5164 */
            ii(0x100d_96a8, 5); mov(edx, 0x3ee);                        /* mov edx, 0x3ee */
            ii(0x100d_96ad, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_96b0, 6); mov(eax, memd_a32[ds, eax + 0x361]);    /* mov eax, [eax+0x361] */
            ii(0x100d_96b6, 5); calld(0x100d_5134, -0x4587);            /* call 0x100d5134 */
            ii(0x100d_96bb, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x100d_96c0, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_96c3, 6); mov(eax, memd_a32[ds, eax + 0x361]);    /* mov eax, [eax+0x361] */
            ii(0x100d_96c9, 5); calld(0x100d_5194, -0x453a);            /* call 0x100d5194 */
            ii(0x100d_96ce, 5); mov(edx, 0x3ef);                        /* mov edx, 0x3ef */
            ii(0x100d_96d3, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_96d6, 6); mov(eax, memd_a32[ds, eax + 0x365]);    /* mov eax, [eax+0x365] */
            ii(0x100d_96dc, 5); calld(0x100d_5164, -0x457d);            /* call 0x100d5164 */
            ii(0x100d_96e1, 5); mov(edx, 0x3f0);                        /* mov edx, 0x3f0 */
            ii(0x100d_96e6, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_96e9, 6); mov(eax, memd_a32[ds, eax + 0x365]);    /* mov eax, [eax+0x365] */
            ii(0x100d_96ef, 5); calld(0x100d_5134, -0x45c0);            /* call 0x100d5134 */
            ii(0x100d_96f4, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x100d_96f9, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_96fc, 6); mov(eax, memd_a32[ds, eax + 0x365]);    /* mov eax, [eax+0x365] */
            ii(0x100d_9702, 5); calld(0x100d_5194, -0x4573);            /* call 0x100d5194 */
            ii(0x100d_9707, 5); mov(edx, 0x3f1);                        /* mov edx, 0x3f1 */
            ii(0x100d_970c, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_970f, 6); mov(eax, memd_a32[ds, eax + 0x369]);    /* mov eax, [eax+0x369] */
            ii(0x100d_9715, 5); calld(0x100d_5164, -0x45b6);            /* call 0x100d5164 */
            ii(0x100d_971a, 5); mov(edx, 0x3f2);                        /* mov edx, 0x3f2 */
            ii(0x100d_971f, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_9722, 6); mov(eax, memd_a32[ds, eax + 0x369]);    /* mov eax, [eax+0x369] */
            ii(0x100d_9728, 5); calld(0x100d_5134, -0x45f9);            /* call 0x100d5134 */
            ii(0x100d_972d, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x100d_9732, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_9735, 6); mov(eax, memd_a32[ds, eax + 0x369]);    /* mov eax, [eax+0x369] */
            ii(0x100d_973b, 5); calld(0x100d_5194, -0x45ac);            /* call 0x100d5194 */
            ii(0x100d_9740, 5); mov(edx, 0x3f3);                        /* mov edx, 0x3f3 */
            ii(0x100d_9745, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_9748, 6); mov(eax, memd_a32[ds, eax + 0x36d]);    /* mov eax, [eax+0x36d] */
            ii(0x100d_974e, 5); calld(0x100d_5164, -0x45ef);            /* call 0x100d5164 */
            ii(0x100d_9753, 5); mov(edx, 0x3f4);                        /* mov edx, 0x3f4 */
            ii(0x100d_9758, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_975b, 6); mov(eax, memd_a32[ds, eax + 0x36d]);    /* mov eax, [eax+0x36d] */
            ii(0x100d_9761, 5); calld(0x100d_5134, -0x4632);            /* call 0x100d5134 */
            ii(0x100d_9766, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x100d_976b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_976e, 6); mov(eax, memd_a32[ds, eax + 0x36d]);    /* mov eax, [eax+0x36d] */
            ii(0x100d_9774, 5); calld(0x100d_5194, -0x45e5);            /* call 0x100d5194 */
            ii(0x100d_9779, 5); mov(edx, 0x3f5);                        /* mov edx, 0x3f5 */
            ii(0x100d_977e, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_9781, 6); mov(eax, memd_a32[ds, eax + 0x371]);    /* mov eax, [eax+0x371] */
            ii(0x100d_9787, 5); calld(0x100d_5164, -0x4628);            /* call 0x100d5164 */
            ii(0x100d_978c, 5); mov(edx, 0x3f6);                        /* mov edx, 0x3f6 */
            ii(0x100d_9791, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_9794, 6); mov(eax, memd_a32[ds, eax + 0x371]);    /* mov eax, [eax+0x371] */
            ii(0x100d_979a, 5); calld(0x100d_5134, -0x466b);            /* call 0x100d5134 */
            ii(0x100d_979f, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x100d_97a4, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_97a7, 6); mov(eax, memd_a32[ds, eax + 0x371]);    /* mov eax, [eax+0x371] */
            ii(0x100d_97ad, 5); calld(0x100d_5194, -0x461e);            /* call 0x100d5194 */
            ii(0x100d_97b2, 5); mov(edx, 0x4e6);                        /* mov edx, 0x4e6 */
            ii(0x100d_97b7, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_97ba, 6); mov(eax, memd_a32[ds, eax + 0x351]);    /* mov eax, [eax+0x351] */
            ii(0x100d_97c0, 5); calld(0x100d_50d4, -0x46f1);            /* call 0x100d50d4 */
            ii(0x100d_97c5, 5); mov(edx, 0x4e5);                        /* mov edx, 0x4e5 */
            ii(0x100d_97ca, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_97cd, 6); mov(eax, memd_a32[ds, eax + 0x355]);    /* mov eax, [eax+0x355] */
            ii(0x100d_97d3, 5); calld(0x100d_50d4, -0x4704);            /* call 0x100d50d4 */
            ii(0x100d_97d8, 5); mov(edx, 0x4e4);                        /* mov edx, 0x4e4 */
            ii(0x100d_97dd, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_97e0, 6); mov(eax, memd_a32[ds, eax + 0x359]);    /* mov eax, [eax+0x359] */
            ii(0x100d_97e6, 5); calld(0x100d_50d4, -0x4717);            /* call 0x100d50d4 */
            ii(0x100d_97eb, 5); mov(edx, 0x4ff);                        /* mov edx, 0x4ff */
            ii(0x100d_97f0, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_97f3, 6); mov(eax, memd_a32[ds, eax + 0x35d]);    /* mov eax, [eax+0x35d] */
            ii(0x100d_97f9, 5); calld(0x100d_50d4, -0x472a);            /* call 0x100d50d4 */
            ii(0x100d_97fe, 5); mov(edx, 0x4ff);                        /* mov edx, 0x4ff */
            ii(0x100d_9803, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_9806, 6); mov(eax, memd_a32[ds, eax + 0x361]);    /* mov eax, [eax+0x361] */
            ii(0x100d_980c, 5); calld(0x100d_50d4, -0x473d);            /* call 0x100d50d4 */
            ii(0x100d_9811, 5); mov(edx, 0x4ff);                        /* mov edx, 0x4ff */
            ii(0x100d_9816, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_9819, 6); mov(eax, memd_a32[ds, eax + 0x365]);    /* mov eax, [eax+0x365] */
            ii(0x100d_981f, 5); calld(0x100d_50d4, -0x4750);            /* call 0x100d50d4 */
            ii(0x100d_9824, 5); mov(edx, 0x4ff);                        /* mov edx, 0x4ff */
            ii(0x100d_9829, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_982c, 6); mov(eax, memd_a32[ds, eax + 0x369]);    /* mov eax, [eax+0x369] */
            ii(0x100d_9832, 5); calld(0x100d_50d4, -0x4763);            /* call 0x100d50d4 */
            ii(0x100d_9837, 5); mov(edx, 0x4ff);                        /* mov edx, 0x4ff */
            ii(0x100d_983c, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_983f, 6); mov(eax, memd_a32[ds, eax + 0x36d]);    /* mov eax, [eax+0x36d] */
            ii(0x100d_9845, 5); calld(0x100d_50d4, -0x4776);            /* call 0x100d50d4 */
            ii(0x100d_984a, 5); mov(edx, 0x4ff);                        /* mov edx, 0x4ff */
            ii(0x100d_984f, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_9852, 6); mov(eax, memd_a32[ds, eax + 0x371]);    /* mov eax, [eax+0x371] */
            ii(0x100d_9858, 5); calld(0x100d_50d4, -0x4789);            /* call 0x100d50d4 */
            ii(0x100d_985d, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100d_9860, 3); mov(edx, memd_a32[ds, edx + 0x29]);     /* mov edx, [edx+0x29] */
            ii(0x100d_9863, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_9866, 6); mov(eax, memd_a32[ds, eax + 0x351]);    /* mov eax, [eax+0x351] */
            ii(0x100d_986c, 5); calld(0x100c_f85c, -0xa015);            /* call 0x100cf85c */
            ii(0x100d_9871, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100d_9874, 3); mov(edx, memd_a32[ds, edx + 0x29]);     /* mov edx, [edx+0x29] */
            ii(0x100d_9877, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_987a, 6); mov(eax, memd_a32[ds, eax + 0x355]);    /* mov eax, [eax+0x355] */
            ii(0x100d_9880, 5); calld(0x100c_f85c, -0xa029);            /* call 0x100cf85c */
            ii(0x100d_9885, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100d_9888, 3); mov(edx, memd_a32[ds, edx + 0x29]);     /* mov edx, [edx+0x29] */
            ii(0x100d_988b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_988e, 6); mov(eax, memd_a32[ds, eax + 0x359]);    /* mov eax, [eax+0x359] */
            ii(0x100d_9894, 5); calld(0x100c_f85c, -0xa03d);            /* call 0x100cf85c */
            ii(0x100d_9899, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_989c, 3); mov(edx, memd_a32[ds, eax + 0x29]);     /* mov edx, [eax+0x29] */
            ii(0x100d_989f, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_98a2, 6); mov(eax, memd_a32[ds, eax + 0x35d]);    /* mov eax, [eax+0x35d] */
            ii(0x100d_98a8, 5); calld(0x100c_f85c, -0xa051);            /* call 0x100cf85c */
            ii(0x100d_98ad, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_98b0, 3); mov(edx, memd_a32[ds, eax + 0x29]);     /* mov edx, [eax+0x29] */
            ii(0x100d_98b3, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_98b6, 6); mov(eax, memd_a32[ds, eax + 0x361]);    /* mov eax, [eax+0x361] */
            ii(0x100d_98bc, 5); calld(0x100c_f85c, -0xa065);            /* call 0x100cf85c */
            ii(0x100d_98c1, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_98c4, 3); mov(edx, memd_a32[ds, eax + 0x29]);     /* mov edx, [eax+0x29] */
            ii(0x100d_98c7, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_98ca, 6); mov(eax, memd_a32[ds, eax + 0x365]);    /* mov eax, [eax+0x365] */
            ii(0x100d_98d0, 5); calld(0x100c_f85c, -0xa079);            /* call 0x100cf85c */
            ii(0x100d_98d5, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100d_98d8, 3); mov(edx, memd_a32[ds, edx + 0x29]);     /* mov edx, [edx+0x29] */
            ii(0x100d_98db, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_98de, 6); mov(eax, memd_a32[ds, eax + 0x369]);    /* mov eax, [eax+0x369] */
            ii(0x100d_98e4, 5); calld(0x100c_f85c, -0xa08d);            /* call 0x100cf85c */
            ii(0x100d_98e9, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100d_98ec, 3); mov(edx, memd_a32[ds, edx + 0x29]);     /* mov edx, [edx+0x29] */
            ii(0x100d_98ef, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_98f2, 6); mov(eax, memd_a32[ds, eax + 0x36d]);    /* mov eax, [eax+0x36d] */
            ii(0x100d_98f8, 5); calld(0x100c_f85c, -0xa0a1);            /* call 0x100cf85c */
            ii(0x100d_98fd, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100d_9900, 3); mov(edx, memd_a32[ds, edx + 0x29]);     /* mov edx, [edx+0x29] */
            ii(0x100d_9903, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_9906, 6); mov(eax, memd_a32[ds, eax + 0x371]);    /* mov eax, [eax+0x371] */
            ii(0x100d_990c, 5); calld(0x100c_f85c, -0xa0b5);            /* call 0x100cf85c */
            ii(0x100d_9911, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_9914, 7); cmp(memb_a32[ds, eax + 0x39d], 0);      /* cmp byte [eax+0x39d], 0x0 */
            ii(0x100d_991b, 2); if(jzd(0x100d_996d, 0x50)) goto l_0x100d_996d; /* jz 0x100d996d */
            ii(0x100d_991d, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100d_991f, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_9922, 6); mov(eax, memd_a32[ds, eax + 0x35d]);    /* mov eax, [eax+0x35d] */
            ii(0x100d_9928, 5); calld(0x100c_fb06, -0x9e27);            /* call 0x100cfb06 */
            ii(0x100d_992d, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100d_992f, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_9932, 6); mov(eax, memd_a32[ds, eax + 0x361]);    /* mov eax, [eax+0x361] */
            ii(0x100d_9938, 5); calld(0x100c_fb06, -0x9e37);            /* call 0x100cfb06 */
            ii(0x100d_993d, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100d_993f, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_9942, 6); mov(eax, memd_a32[ds, eax + 0x365]);    /* mov eax, [eax+0x365] */
            ii(0x100d_9948, 5); calld(0x100c_fb06, -0x9e47);            /* call 0x100cfb06 */
            ii(0x100d_994d, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100d_994f, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_9952, 6); mov(eax, memd_a32[ds, eax + 0x369]);    /* mov eax, [eax+0x369] */
            ii(0x100d_9958, 5); calld(0x100c_fb06, -0x9e57);            /* call 0x100cfb06 */
            ii(0x100d_995d, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100d_995f, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_9962, 6); mov(eax, memd_a32[ds, eax + 0x36d]);    /* mov eax, [eax+0x36d] */
            ii(0x100d_9968, 5); calld(0x100c_fb06, -0x9e67);            /* call 0x100cfb06 */
        l_0x100d_996d:
            ii(0x100d_996d, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100d_996f, 6); mov(dl, memb_a32[ds, 0x101b_7ecc]);     /* mov dl, [0x101b7ecc] */
            ii(0x100d_9975, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_9978, 6); mov(eax, memd_a32[ds, eax + 0x35d]);    /* mov eax, [eax+0x35d] */
            ii(0x100d_997e, 5); calld(0x100c_fb73, -0x9e10);            /* call 0x100cfb73 */
            ii(0x100d_9983, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100d_9985, 6); mov(dl, memb_a32[ds, 0x101b_7ecd]);     /* mov dl, [0x101b7ecd] */
            ii(0x100d_998b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_998e, 6); mov(eax, memd_a32[ds, eax + 0x361]);    /* mov eax, [eax+0x361] */
            ii(0x100d_9994, 5); calld(0x100c_fb73, -0x9e26);            /* call 0x100cfb73 */
            ii(0x100d_9999, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100d_999b, 6); mov(dl, memb_a32[ds, 0x101b_7ece]);     /* mov dl, [0x101b7ece] */
            ii(0x100d_99a1, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_99a4, 6); mov(eax, memd_a32[ds, eax + 0x365]);    /* mov eax, [eax+0x365] */
            ii(0x100d_99aa, 5); calld(0x100c_fb73, -0x9e3c);            /* call 0x100cfb73 */
            ii(0x100d_99af, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100d_99b1, 6); mov(dl, memb_a32[ds, 0x101b_7ecf]);     /* mov dl, [0x101b7ecf] */
            ii(0x100d_99b7, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_99ba, 6); mov(eax, memd_a32[ds, eax + 0x369]);    /* mov eax, [eax+0x369] */
            ii(0x100d_99c0, 5); calld(0x100c_fb73, -0x9e52);            /* call 0x100cfb73 */
            ii(0x100d_99c5, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100d_99c7, 6); mov(dl, memb_a32[ds, 0x101c_3604]);     /* mov dl, [0x101c3604] */
            ii(0x100d_99cd, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_99d0, 6); mov(eax, memd_a32[ds, eax + 0x36d]);    /* mov eax, [eax+0x36d] */
            ii(0x100d_99d6, 5); calld(0x100c_fb73, -0x9e68);            /* call 0x100cfb73 */
            ii(0x100d_99db, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100d_99dd, 6); mov(dl, memb_a32[ds, 0x101b_7ed0]);     /* mov dl, [0x101b7ed0] */
            ii(0x100d_99e3, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_99e6, 6); mov(eax, memd_a32[ds, eax + 0x371]);    /* mov eax, [eax+0x371] */
            ii(0x100d_99ec, 5); calld(0x100c_fb73, -0x9e7e);            /* call 0x100cfb73 */
            ii(0x100d_99f1, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100d_99f4, 3); add(edx, 0x17);                         /* add edx, 0x17 */
            ii(0x100d_99f7, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_99fa, 6); mov(eax, memd_a32[ds, eax + 0x39f]);    /* mov eax, [eax+0x39f] */
            ii(0x100d_9a00, 5); calld(0x100d_7d74, -0x1c91);            /* call 0x100d7d74 */
            ii(0x100d_9a05, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100d_9a08, 3); add(edx, 0x17);                         /* add edx, 0x17 */
            ii(0x100d_9a0b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_9a0e, 6); mov(eax, memd_a32[ds, eax + 0x3a3]);    /* mov eax, [eax+0x3a3] */
            ii(0x100d_9a14, 5); calld(0x100d_7d74, -0x1ca5);            /* call 0x100d7d74 */
            ii(0x100d_9a19, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100d_9a1c, 3); add(edx, 0x17);                         /* add edx, 0x17 */
            ii(0x100d_9a1f, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_9a22, 6); mov(eax, memd_a32[ds, eax + 0x3ab]);    /* mov eax, [eax+0x3ab] */
            ii(0x100d_9a28, 5); calld(0x100d_7d74, -0x1cb9);            /* call 0x100d7d74 */
            ii(0x100d_9a2d, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100d_9a30, 3); add(edx, 0x17);                         /* add edx, 0x17 */
            ii(0x100d_9a33, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_9a36, 6); mov(eax, memd_a32[ds, eax + 0x3a7]);    /* mov eax, [eax+0x3a7] */
            ii(0x100d_9a3c, 5); calld(0x100d_7d74, -0x1ccd);            /* call 0x100d7d74 */
            ii(0x100d_9a41, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100d_9a43, 1); popd(ebp);                              /* pop ebp */
            ii(0x100d_9a44, 1); popd(edi);                              /* pop edi */
            ii(0x100d_9a45, 1); popd(esi);                              /* pop esi */
            ii(0x100d_9a46, 1); popd(edx);                              /* pop edx */
            ii(0x100d_9a47, 1); popd(ecx);                              /* pop ecx */
            ii(0x100d_9a48, 1); popd(ebx);                              /* pop ebx */
            ii(0x100d_9a49, 1); retd(); return;                         /* ret */
        }
    }
}