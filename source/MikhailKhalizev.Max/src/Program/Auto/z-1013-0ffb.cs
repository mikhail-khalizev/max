using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_0ffb-817cd1cf")]
        public void Method_1013_0ffb()
        {
            ii(0x1013_0ffb, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1013_1000, 5); calld(Definitions.sys_check_available_stack_size, 0x3_4d4d); /* call 0x10165d52 */
            ii(0x1013_1005, 1); pushd(ebx);                             /* push ebx */
            ii(0x1013_1006, 1); pushd(ecx);                             /* push ecx */
            ii(0x1013_1007, 1); pushd(esi);                             /* push esi */
            ii(0x1013_1008, 1); pushd(edi);                             /* push edi */
            ii(0x1013_1009, 1); pushd(ebp);                             /* push ebp */
            ii(0x1013_100a, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_100c, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1013_1012, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1013_1015, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1013_1018, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1013_101b, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1013_101e, 7); mov(memb_a32[ds, 0x101b_b48f], 0x1);    /* mov byte [0x101bb48f], 0x1 */
            ii(0x1013_1025, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1013_1028, 5); calld(0x1012_f003, -0x202a);            /* call 0x1012f003 */
            ii(0x1013_102d, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1013_1030, 4); cmp(memb_a32[ds, eax + 0x17], 0);       /* cmp byte [eax+0x17], 0x0 */
            ii(0x1013_1034, 2); if(jzd(0x1013_103f, 0x9)) goto l_0x1013_103f; /* jz 0x1013103f */
            ii(0x1013_1036, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1013_1039, 4); cmp(memb_a32[ds, eax + 0x17], 0x1);     /* cmp byte [eax+0x17], 0x1 */
            ii(0x1013_103d, 2); if(jnzd(0x1013_104c, 0xd)) goto l_0x1013_104c; /* jnz 0x1013104c */
        l_0x1013_103f:
            ii(0x1013_103f, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x1013_1044, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1013_1047, 5); calld(0x1013_0c16, -0x436);             /* call 0x10130c16 */
        l_0x1013_104c:
            ii(0x1013_104c, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_104e, 1); popd(ebp);                              /* pop ebp */
            ii(0x1013_104f, 1); popd(edi);                              /* pop edi */
            ii(0x1013_1050, 1); popd(esi);                              /* pop esi */
            ii(0x1013_1051, 1); popd(ecx);                              /* pop ecx */
            ii(0x1013_1052, 1); popd(ebx);                              /* pop ebx */
            ii(0x1013_1053, 1); retd();                                 /* ret */
        }
    }
}
