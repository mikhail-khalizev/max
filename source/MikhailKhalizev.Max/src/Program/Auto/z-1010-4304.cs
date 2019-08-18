using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1010_4304-d601fc05")]
        public void Method_1010_4304()
        {
            ii(0x1010_4304, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1010_4309, 5); calld(Definitions.sys_check_available_stack_size, 0x6_1a44); /* call 0x10165d52 */
            ii(0x1010_430e, 1); pushd(ebx);                             /* push ebx */
            ii(0x1010_430f, 1); pushd(ecx);                             /* push ecx */
            ii(0x1010_4310, 1); pushd(esi);                             /* push esi */
            ii(0x1010_4311, 1); pushd(edi);                             /* push edi */
            ii(0x1010_4312, 1); pushd(ebp);                             /* push ebp */
            ii(0x1010_4313, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1010_4315, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1010_431b, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1010_431e, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1010_4321, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1010_4324, 3); movsx(ebx, memw_a32[ds, eax]);          /* movsx ebx, word [eax] */
            ii(0x1010_4327, 5); mov(edx, StringDefinitions.HashSize4);  /* mov edx, 0x101a32cb */
            ii(0x1010_432c, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_432f, 5); calld(0x1014_74f5, 0x4_31c1);           /* call 0x101474f5 */
            ii(0x1010_4334, 7); mov(memd_a32[ss, ebp - 0xc], 0);        /* mov dword [ebp-0xc], 0x0 */
            ii(0x1010_433b, 2); jmpd(0x1010_4343, 0x6); goto l_0x1010_4343; /* jmp 0x10104343 */
        l_0x1010_433d:
            ii(0x1010_433d, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1010_4340, 3); inc(memd_a32[ss, ebp - 0xc]);           /* inc dword [ebp-0xc] */
        l_0x1010_4343:
            ii(0x1010_4343, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1010_4346, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1010_4349, 3); cmp(ax, memw_a32[ds, edx]);             /* cmp ax, [edx] */
            ii(0x1010_434c, 2); if(jged(0x1010_43a6, 0x58)) goto l_0x1010_43a6; /* jge 0x101043a6 */
            ii(0x1010_434e, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x1010_4352, 3); imul(edx, eax, 0xa);                    /* imul edx, eax, 0xa */
            ii(0x1010_4355, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1010_4358, 3); mov(eax, memd_a32[ds, eax + 0x2]);      /* mov eax, [eax+0x2] */
            ii(0x1010_435b, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1010_435d, 5); calld(0x1007_6b90, -0x8_d7d2);          /* call 0x10076b90 */
            ii(0x1010_4362, 1); cwde();                                 /* cwde */
            ii(0x1010_4363, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1010_4365, 2); if(jled(0x1010_43a4, 0x3d)) goto l_0x1010_43a4; /* jle 0x101043a4 */
            ii(0x1010_4367, 5); mov(edx, StringDefinitions.List4);      /* mov edx, 0x101a32d5 */
            ii(0x1010_436c, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_436f, 5); calld(0x1014_73de, 0x4_306a);           /* call 0x101473de */
            ii(0x1010_4374, 4); movsx(ebx, memw_a32[ss, ebp - 0xc]);    /* movsx ebx, word [ebp-0xc] */
            ii(0x1010_4378, 5); mov(edx, StringDefinitions.Index8);     /* mov edx, 0x101a32da */
            ii(0x1010_437d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_4380, 5); calld(0x1014_74f5, 0x4_3170);           /* call 0x101474f5 */
            ii(0x1010_4385, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1010_4388, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x1010_438c, 3); imul(ebx, eax, 0xa);                    /* imul ebx, eax, 0xa */
            ii(0x1010_438f, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1010_4392, 3); mov(eax, memd_a32[ds, eax + 0x2]);      /* mov eax, [eax+0x2] */
            ii(0x1010_4395, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x1010_4397, 5); calld(0x1010_2ff9, -0x13a3);            /* call 0x10102ff9 */
            ii(0x1010_439c, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_439f, 5); calld(0x1014_7446, 0x4_30a2);           /* call 0x10147446 */
        l_0x1010_43a4:
            ii(0x1010_43a4, 2); jmpd(0x1010_433d, -0x69); goto l_0x1010_433d; /* jmp 0x1010433d */
        l_0x1010_43a6:
            ii(0x1010_43a6, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1010_43a8, 1); popd(ebp);                              /* pop ebp */
            ii(0x1010_43a9, 1); popd(edi);                              /* pop edi */
            ii(0x1010_43aa, 1); popd(esi);                              /* pop esi */
            ii(0x1010_43ab, 1); popd(ecx);                              /* pop ecx */
            ii(0x1010_43ac, 1); popd(ebx);                              /* pop ebx */
            ii(0x1010_43ad, 1); retd(); return;                         /* ret */
        }
    }
}
