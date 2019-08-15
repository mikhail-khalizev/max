using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("dd79ca84-ac43-4dd9-bccc-377e49ae1401")]
        public void Method_1016_0283()
        {
            ii(0x1016_0283, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x1016_0288, 5); calld(Definitions.sys_check_available_stack_size, 0x5ac5); /* call 0x10165d52 */
            ii(0x1016_028d, 1); pushd(ebx);                             /* push ebx */
            ii(0x1016_028e, 1); pushd(ecx);                             /* push ecx */
            ii(0x1016_028f, 1); pushd(edx);                             /* push edx */
            ii(0x1016_0290, 1); pushd(esi);                             /* push esi */
            ii(0x1016_0291, 1); pushd(edi);                             /* push edi */
            ii(0x1016_0292, 1); pushd(ebp);                             /* push ebp */
            ii(0x1016_0293, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1016_0295, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1016_029b, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1016_029e, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_02a1, 5); calld(0x1014_9fa8, -0x1_62fe);          /* call 0x10149fa8 */
            ii(0x1016_02a6, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_02a9, 5); calld(0x1016_013b, -0x173);             /* call 0x1016013b */
            ii(0x1016_02ae, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_02b1, 4); cmp(memb_a32[ds, eax + 0x3e], 0);       /* cmp byte [eax+0x3e], 0x0 */
            ii(0x1016_02b5, 2); if(jnzd(0x1016_02f3, 0x3c)) goto l_0x1016_02f3; /* jnz 0x101602f3 */
            ii(0x1016_02b7, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_02ba, 5); calld(0x1014_f12b, -0x1_1194);          /* call 0x1014f12b */
            ii(0x1016_02bf, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_02c2, 5); calld(0x1015_48ba, -0xba0d);            /* call 0x101548ba */
            ii(0x1016_02c7, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_02ca, 4); mov(memb_a32[ds, eax + 0x3e], 0x5);     /* mov byte [eax+0x3e], 0x5 */
            ii(0x1016_02ce, 7); cmp(memd_a32[ds, 0x101c_5624], 0);      /* cmp dword [0x101c5624], 0x0 */
            ii(0x1016_02d5, 2); if(jzd(0x1016_02e0, 0x9)) goto l_0x1016_02e0; /* jz 0x101602e0 */
            ii(0x1016_02d7, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_02da, 4); test(memb_a32[ds, eax + 0x12], 0x40);   /* test byte [eax+0x12], 0x40 */
            ii(0x1016_02de, 2); if(jnzd(0x1016_02e2, 0x2)) goto l_0x1016_02e2; /* jnz 0x101602e2 */
        l_0x1016_02e0:
            ii(0x1016_02e0, 2); jmpd(0x1016_02f3, 0x11); goto l_0x1016_02f3; /* jmp 0x101602f3 */
        l_0x1016_02e2:
            ii(0x1016_02e2, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_02e5, 5); calld(0x1012_ae8d, -0x3_545d);          /* call 0x1012ae8d */
            ii(0x1016_02ea, 7); mov(memd_a32[ss, ebp - 0x8], 0);        /* mov dword [ebp-0x8], 0x0 */
            ii(0x1016_02f1, 2); jmpd(0x1016_0312, 0x1f); goto l_0x1016_0312; /* jmp 0x10160312 */
        l_0x1016_02f3:
            ii(0x1016_02f3, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_02f6, 4); cmp(memb_a32[ds, eax + 0x3e], 0x5);     /* cmp byte [eax+0x3e], 0x5 */
            ii(0x1016_02fa, 2); if(jnzd(0x1016_0305, 0x9)) goto l_0x1016_0305; /* jnz 0x10160305 */
            ii(0x1016_02fc, 7); mov(memd_a32[ss, ebp - 0xc], 0x1);      /* mov dword [ebp-0xc], 0x1 */
            ii(0x1016_0303, 2); jmpd(0x1016_030c, 0x7); goto l_0x1016_030c; /* jmp 0x1016030c */
        l_0x1016_0305:
            ii(0x1016_0305, 7); mov(memd_a32[ss, ebp - 0xc], 0);        /* mov dword [ebp-0xc], 0x0 */
        l_0x1016_030c:
            ii(0x1016_030c, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1016_030f, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
        l_0x1016_0312:
            ii(0x1016_0312, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1016_0315, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1016_0317, 1); popd(ebp);                              /* pop ebp */
            ii(0x1016_0318, 1); popd(edi);                              /* pop edi */
            ii(0x1016_0319, 1); popd(esi);                              /* pop esi */
            ii(0x1016_031a, 1); popd(edx);                              /* pop edx */
            ii(0x1016_031b, 1); popd(ecx);                              /* pop ecx */
            ii(0x1016_031c, 1); popd(ebx);                              /* pop ebx */
            ii(0x1016_031d, 1); retd(); return;                         /* ret */
        }
    }
}
