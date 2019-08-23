using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_106c-f407abf8")]
        public void Method_100a_106c()
        {
            ii(0x100a_106c, 5); pushd(0x160);                           /* push 0x160 */
            ii(0x100a_1071, 5); calld(Definitions.sys_check_available_stack_size, 0xc_4cdc); /* call 0x10165d52 */
            ii(0x100a_1076, 1); pushd(ebx);                             /* push ebx */
            ii(0x100a_1077, 1); pushd(ecx);                             /* push ecx */
            ii(0x100a_1078, 1); pushd(esi);                             /* push esi */
            ii(0x100a_1079, 1); pushd(edi);                             /* push edi */
            ii(0x100a_107a, 1); pushd(ebp);                             /* push ebp */
            ii(0x100a_107b, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_107d, 6); sub(esp, 0x138);                        /* sub esp, 0x138 */
            ii(0x100a_1083, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100a_1086, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100a_1089, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x100a_108d, 5); calld(0x1007_1ec5, -0x2_f1cd);          /* call 0x10071ec5 */
            ii(0x100a_1092, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100a_1094, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_1097, 4); cmp(dx, memw_a32[ds, eax + 0x2e]);      /* cmp dx, [eax+0x2e] */
            ii(0x100a_109b, 2); if(jgd(0x100a_10a3, 0x6)) goto l_0x100a_10a3; /* jg 0x100a10a3 */
            ii(0x100a_109d, 4); mov(memb_a32[ss, ebp - 0xc], 0);        /* mov byte [ebp-0xc], 0x0 */
            ii(0x100a_10a1, 2); jmpd(0x100a_1102, 0x5f); goto l_0x100a_1102; /* jmp 0x100a1102 */
        l_0x100a_10a3:
            ii(0x100a_10a3, 3); lea(edx, ebp - 0x4);                    /* lea edx, [ebp-0x4] */
            ii(0x100a_10a6, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_10a9, 3); add(eax, 0x48);                         /* add eax, 0x48 */
            ii(0x100a_10ac, 5); calld(0x1008_b268, -0x1_5e49);          /* call 0x1008b268 */
            ii(0x100a_10b1, 1); cwde();                                 /* cwde */
            ii(0x100a_10b2, 3); cmp(eax, -0x1 /* 0xff */);              /* cmp eax, 0xffffffff */
            ii(0x100a_10b5, 2); if(jnzd(0x100a_10fe, 0x47)) goto l_0x100a_10fe; /* jnz 0x100a10fe */
            ii(0x100a_10b7, 3); lea(edx, ebp - 0x4);                    /* lea edx, [ebp-0x4] */
            ii(0x100a_10ba, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_10bd, 3); add(eax, 0x48);                         /* add eax, 0x48 */
            ii(0x100a_10c0, 5); calld(0x1008_b2a8, -0x1_5e1d);          /* call 0x1008b2a8 */
            ii(0x100a_10c5, 5); mov(eax, StringDefinitions.Fuel2);      /* mov eax, 0x101a0922 */
            ii(0x100a_10ca, 1); pushd(eax);                             /* push eax */
            ii(0x100a_10cb, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x100a_10cf, 3); imul(eax, eax, 0x33);                   /* imul eax, eax, 0x33 */
            ii(0x100a_10d2, 6); pushd(memd_a32[ds, eax + 0x101c_81d7]); /* push dword [eax+0x101c81d7] */
            ii(0x100a_10d8, 5); mov(eax, StringDefinitions.CannotTurnSOnSNeeded4); /* mov eax, 0x101a0927 */
            ii(0x100a_10dd, 1); pushd(eax);                             /* push eax */
            ii(0x100a_10de, 6); lea(eax, ebp - 0x138);                  /* lea eax, [ebp-0x138] */
            ii(0x100a_10e4, 1); pushd(eax);                             /* push eax */
            ii(0x100a_10e5, 5); calld(Definitions.sys_sprintf, 0xc_4e17); /* call 0x10165f01 */
            ii(0x100a_10ea, 3); add(esp, 0x10);                         /* add esp, 0x10 */
            ii(0x100a_10ed, 6); lea(edx, ebp - 0x138);                  /* lea edx, [ebp-0x138] */
            ii(0x100a_10f3, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_10f6, 3); add(eax, 0x4d);                         /* add eax, 0x4d */
            ii(0x100a_10f9, 5); calld(Definitions.sys_strcat, 0xc_4e33); /* call 0x10165f31 */
        l_0x100a_10fe:
            ii(0x100a_10fe, 4); mov(memb_a32[ss, ebp - 0xc], 0x1);      /* mov byte [ebp-0xc], 0x1 */
        l_0x100a_1102:
            ii(0x100a_1102, 3); mov(al, memb_a32[ss, ebp - 0xc]);       /* mov al, [ebp-0xc] */
            ii(0x100a_1105, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_1107, 1); popd(ebp);                              /* pop ebp */
            ii(0x100a_1108, 1); popd(edi);                              /* pop edi */
            ii(0x100a_1109, 1); popd(esi);                              /* pop esi */
            ii(0x100a_110a, 1); popd(ecx);                              /* pop ecx */
            ii(0x100a_110b, 1); popd(ebx);                              /* pop ebx */
            ii(0x100a_110c, 1); retd();                                 /* ret */
        }
    }
}
