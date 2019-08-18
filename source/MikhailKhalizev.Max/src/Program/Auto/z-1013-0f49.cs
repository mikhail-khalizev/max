using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("08d13d26-9446-40e6-83ea-09992851c5ab")]
        public void Method_1013_0f49()
        {
            ii(0x1013_0f49, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1013_0f4e, 5); calld(Definitions.sys_check_available_stack_size, 0x3_4dff); /* call 0x10165d52 */
            ii(0x1013_0f53, 1); pushd(ebx);                             /* push ebx */
            ii(0x1013_0f54, 1); pushd(ecx);                             /* push ecx */
            ii(0x1013_0f55, 1); pushd(esi);                             /* push esi */
            ii(0x1013_0f56, 1); pushd(edi);                             /* push edi */
            ii(0x1013_0f57, 1); pushd(ebp);                             /* push ebp */
            ii(0x1013_0f58, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_0f5a, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1013_0f60, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1013_0f63, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1013_0f66, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1013_0f69, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1013_0f6c, 7); mov(memb_a32[ds, 0x101b_b48e], 0x1);    /* mov byte [0x101bb48e], 0x1 */
            ii(0x1013_0f73, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1013_0f76, 5); calld(0x1012_f003, -0x1f78);            /* call 0x1012f003 */
            ii(0x1013_0f7b, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1013_0f7e, 4); cmp(memb_a32[ds, eax + 0x17], 0);       /* cmp byte [eax+0x17], 0x0 */
            ii(0x1013_0f82, 2); if(jzd(0x1013_0f8d, 0x9)) goto l_0x1013_0f8d; /* jz 0x10130f8d */
            ii(0x1013_0f84, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1013_0f87, 4); cmp(memb_a32[ds, eax + 0x17], 0x1);     /* cmp byte [eax+0x17], 0x1 */
            ii(0x1013_0f8b, 2); if(jnzd(0x1013_0f9a, 0xd)) goto l_0x1013_0f9a; /* jnz 0x10130f9a */
        l_0x1013_0f8d:
            ii(0x1013_0f8d, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x1013_0f92, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1013_0f95, 5); calld(0x1013_0c16, -0x384);             /* call 0x10130c16 */
        l_0x1013_0f9a:
            ii(0x1013_0f9a, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_0f9c, 1); popd(ebp);                              /* pop ebp */
            ii(0x1013_0f9d, 1); popd(edi);                              /* pop edi */
            ii(0x1013_0f9e, 1); popd(esi);                              /* pop esi */
            ii(0x1013_0f9f, 1); popd(ecx);                              /* pop ecx */
            ii(0x1013_0fa0, 1); popd(ebx);                              /* pop ebx */
            ii(0x1013_0fa1, 1); retd(); return;                         /* ret */
        }
    }
}
