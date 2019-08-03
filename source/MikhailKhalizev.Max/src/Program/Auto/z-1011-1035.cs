using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("13cf97bb-a61b-4b11-a808-833d4e6f46fd")]
        public void Method_1011_1035()
        {
            ii(0x1011_1035, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1011_103a, 5); calld(Definitions.sys_check_available_stack_size, 0x54d13); /* call 0x10165d52 */
            ii(0x1011_103f, 1); pushd(ebx);                             /* push ebx */
            ii(0x1011_1040, 1); pushd(ecx);                             /* push ecx */
            ii(0x1011_1041, 1); pushd(edx);                             /* push edx */
            ii(0x1011_1042, 1); pushd(esi);                             /* push esi */
            ii(0x1011_1043, 1); pushd(edi);                             /* push edi */
            ii(0x1011_1044, 1); pushd(ebp);                             /* push ebp */
            ii(0x1011_1045, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1011_1047, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1011_104d, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1011_1050, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_1053, 4); cmp(memd_a32[ds, eax + 0xc], 0xc);      /* cmp dword [eax+0xc], 0xc */
            ii(0x1011_1057, 2); if(jnzd(0x1011_1075, 0x1c)) goto l_0x1011_1075; /* jnz 0x10111075 */
            ii(0x1011_1059, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x1011_105d, 3); cmp(eax, 0x1);                          /* cmp eax, 0x1 */
            ii(0x1011_1060, 2); if(jzd(0x1011_10b4, 0x52)) goto l_0x1011_10b4; /* jz 0x101110b4 */
            ii(0x1011_1062, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_1065, 6); mov(al, memb_a32[ds, eax + 0x140]);     /* mov al, [eax+0x140] */
            ii(0x1011_106b, 2); xor(ah, ah);                            /* xor ah, ah */
            ii(0x1011_106d, 3); sub(eax, 0xc);                          /* sub eax, 0xc */
            ii(0x1011_1070, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1011_1073, 2); jmpd(0x1011_1088, 0x13); goto l_0x1011_1088; /* jmp 0x10111088 */
        l_0x1011_1075:
            ii(0x1011_1075, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_1078, 6); mov(al, memb_a32[ds, eax + 0x140]);     /* mov al, [eax+0x140] */
            ii(0x1011_107e, 2); xor(ah, ah);                            /* xor ah, ah */
            ii(0x1011_1080, 5); add(eax, 0xc);                          /* add eax, 0xc */
            ii(0x1011_1085, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
        l_0x1011_1088:
            ii(0x1011_1088, 4); movsx(edx, memw_a32[ss, ebp - 0x8]);    /* movsx edx, word [ebp-0x8] */
            ii(0x1011_108c, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_108f, 5); calld(0x1011_0e5a, -0x23a);             /* call 0x10110e5a */
            ii(0x1011_1094, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1011_1096, 2); if(jzd(0x1011_10b4, 0x1c)) goto l_0x1011_10b4; /* jz 0x101110b4 */
            ii(0x1011_1098, 3); mov(al, memb_a32[ss, ebp - 0x8]);       /* mov al, [ebp-0x8] */
            ii(0x1011_109b, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1011_109e, 6); mov(memb_a32[ds, edx + 0x140], al);     /* mov [edx+0x140], al */
            ii(0x1011_10a4, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_10a7, 5); calld(0x1011_0812, -0x89a);             /* call 0x10110812 */
            ii(0x1011_10ac, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_10af, 5); calld(0x1011_0496, -0xc1e);             /* call 0x10110496 */
        l_0x1011_10b4:
            ii(0x1011_10b4, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1011_10b6, 1); popd(ebp);                              /* pop ebp */
            ii(0x1011_10b7, 1); popd(edi);                              /* pop edi */
            ii(0x1011_10b8, 1); popd(esi);                              /* pop esi */
            ii(0x1011_10b9, 1); popd(edx);                              /* pop edx */
            ii(0x1011_10ba, 1); popd(ecx);                              /* pop ecx */
            ii(0x1011_10bb, 1); popd(ebx);                              /* pop ebx */
            ii(0x1011_10bc, 1); retd(); return;                         /* ret */
        }
    }
}
