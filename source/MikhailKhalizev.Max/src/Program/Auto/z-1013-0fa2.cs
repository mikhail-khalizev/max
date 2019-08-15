using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("5517c2c2-ae3d-4158-af9d-eb9ab49c215f")]
        public void Method_1013_0fa2()
        {
            ii(0x1013_0fa2, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1013_0fa7, 5); calld(Definitions.sys_check_available_stack_size, 0x3_4da6); /* call 0x10165d52 */
            ii(0x1013_0fac, 1); pushd(ebx);                             /* push ebx */
            ii(0x1013_0fad, 1); pushd(ecx);                             /* push ecx */
            ii(0x1013_0fae, 1); pushd(esi);                             /* push esi */
            ii(0x1013_0faf, 1); pushd(edi);                             /* push edi */
            ii(0x1013_0fb0, 1); pushd(ebp);                             /* push ebp */
            ii(0x1013_0fb1, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_0fb3, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1013_0fb9, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1013_0fbc, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1013_0fbf, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1013_0fc2, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1013_0fc5, 7); mov(memb_a32[ds, 0x101b_b48e], 0);      /* mov byte [0x101bb48e], 0x0 */
            ii(0x1013_0fcc, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1013_0fcf, 5); calld(0x1012_f003, -0x1fd1);            /* call 0x1012f003 */
            ii(0x1013_0fd4, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1013_0fd7, 4); cmp(memb_a32[ds, eax + 0x17], 0);       /* cmp byte [eax+0x17], 0x0 */
            ii(0x1013_0fdb, 2); if(jzd(0x1013_0fe6, 0x9)) goto l_0x1013_0fe6; /* jz 0x10130fe6 */
            ii(0x1013_0fdd, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1013_0fe0, 4); cmp(memb_a32[ds, eax + 0x17], 0x1);     /* cmp byte [eax+0x17], 0x1 */
            ii(0x1013_0fe4, 2); if(jnzd(0x1013_0ff3, 0xd)) goto l_0x1013_0ff3; /* jnz 0x10130ff3 */
        l_0x1013_0fe6:
            ii(0x1013_0fe6, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x1013_0feb, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1013_0fee, 5); calld(0x1013_0c16, -0x3dd);             /* call 0x10130c16 */
        l_0x1013_0ff3:
            ii(0x1013_0ff3, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_0ff5, 1); popd(ebp);                              /* pop ebp */
            ii(0x1013_0ff6, 1); popd(edi);                              /* pop edi */
            ii(0x1013_0ff7, 1); popd(esi);                              /* pop esi */
            ii(0x1013_0ff8, 1); popd(ecx);                              /* pop ecx */
            ii(0x1013_0ff9, 1); popd(ebx);                              /* pop ebx */
            ii(0x1013_0ffa, 1); retd(); return;                         /* ret */
        }
    }
}
