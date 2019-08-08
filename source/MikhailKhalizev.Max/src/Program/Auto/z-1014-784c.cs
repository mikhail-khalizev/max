using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("af2cfebd-29a5-4b2d-a34f-5045140cd7d6")]
        public void Method_1014_784c()
        {
            ii(0x1014_784c, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x1014_7851, 5); calld(Definitions.sys_check_available_stack_size, 0x1_e4fc); /* call 0x10165d52 */
            ii(0x1014_7856, 1); pushd(ebx);                             /* push ebx */
            ii(0x1014_7857, 1); pushd(ecx);                             /* push ecx */
            ii(0x1014_7858, 1); pushd(edx);                             /* push edx */
            ii(0x1014_7859, 1); pushd(esi);                             /* push esi */
            ii(0x1014_785a, 1); pushd(edi);                             /* push edi */
            ii(0x1014_785b, 1); pushd(ebp);                             /* push ebp */
            ii(0x1014_785c, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_785e, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1014_7864, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1014_7867, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_786a, 5); calld(Definitions.my_string_ctor, -0x5d87); /* call 0x10141ae8 */
            ii(0x1014_786f, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1014_7872, 3); lea(eax, ebp - 0x4);                    /* lea eax, [ebp-0x4] */
            ii(0x1014_7875, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1014_7878, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_787b, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1014_787e, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1014_7881, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_7883, 1); popd(ebp);                              /* pop ebp */
            ii(0x1014_7884, 1); popd(edi);                              /* pop edi */
            ii(0x1014_7885, 1); popd(esi);                              /* pop esi */
            ii(0x1014_7886, 1); popd(edx);                              /* pop edx */
            ii(0x1014_7887, 1); popd(ecx);                              /* pop ecx */
            ii(0x1014_7888, 1); popd(ebx);                              /* pop ebx */
            ii(0x1014_7889, 1); retd(); return;                         /* ret */
        }
    }
}
