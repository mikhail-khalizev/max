using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("ac1f5c54-e171-4b06-9cbb-2e74cc527f45")]
        public void Method_100f_4918()
        {
            ii(0x100f_4918, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x100f_491d, 5); calld(Definitions.sys_check_available_stack_size, 0x7_1430); /* call 0x10165d52 */
            ii(0x100f_4922, 1); pushd(ebx);                             /* push ebx */
            ii(0x100f_4923, 1); pushd(ecx);                             /* push ecx */
            ii(0x100f_4924, 1); pushd(edx);                             /* push edx */
            ii(0x100f_4925, 1); pushd(esi);                             /* push esi */
            ii(0x100f_4926, 1); pushd(edi);                             /* push edi */
            ii(0x100f_4927, 1); pushd(ebp);                             /* push ebp */
            ii(0x100f_4928, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100f_492a, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x100f_4930, 3); mov(memb_a32[ss, ebp - 0x4], al);       /* mov [ebp-0x4], al */
            ii(0x100f_4933, 3); mov(al, memb_a32[ss, ebp - 0x4]);       /* mov al, [ebp-0x4] */
            ii(0x100f_4936, 5); mov(memb_a32[ds, 0x101c_37cb], al);     /* mov [0x101c37cb], al */
            ii(0x100f_493b, 5); mov(al, memb_a32[ds, 0x101c_37cb]);     /* mov al, [0x101c37cb] */
            ii(0x100f_4940, 5); mov(memb_a32[ds, 0x101b_8861], al);     /* mov [0x101b8861], al */
            ii(0x100f_4945, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_4947, 6); mov(dl, memb_a32[ds, 0x101c_37cb]);     /* mov dl, [0x101c37cb] */
            ii(0x100f_494d, 5); mov(eax, memd_a32[ds, 0x101b_885d]);    /* mov eax, [0x101b885d] */
            ii(0x100f_4952, 5); calld(0x100c_fb73, -0x2_4de4);          /* call 0x100cfb73 */
            ii(0x100f_4957, 5); calld(0x100f_f5c1, 0xac65);             /* call 0x100ff5c1 */
            ii(0x100f_495c, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100f_495e, 1); popd(ebp);                              /* pop ebp */
            ii(0x100f_495f, 1); popd(edi);                              /* pop edi */
            ii(0x100f_4960, 1); popd(esi);                              /* pop esi */
            ii(0x100f_4961, 1); popd(edx);                              /* pop edx */
            ii(0x100f_4962, 1); popd(ecx);                              /* pop ecx */
            ii(0x100f_4963, 1); popd(ebx);                              /* pop ebx */
            ii(0x100f_4964, 1); retd(); return;                         /* ret */
        }
    }
}
