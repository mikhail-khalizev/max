using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("b0b80688-dc06-41cd-8f3f-d3abb48910c9")]
        public void Method_1009_cab0()
        {
            ii(0x1009_cab0, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x1009_cab5, 5); calld(Definitions.sys_check_available_stack_size, 0xc_9298); /* call 0x10165d52 */
            ii(0x1009_caba, 1); pushd(ecx);                             /* push ecx */
            ii(0x1009_cabb, 1); pushd(esi);                             /* push esi */
            ii(0x1009_cabc, 1); pushd(edi);                             /* push edi */
            ii(0x1009_cabd, 1); pushd(ebp);                             /* push ebp */
            ii(0x1009_cabe, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_cac0, 6); sub(esp, 0x14);                         /* sub esp, 0x14 */
            ii(0x1009_cac6, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1009_cac9, 3); mov(memd_a32[ss, ebp - 0x8], edx);      /* mov [ebp-0x8], edx */
            ii(0x1009_cacc, 3); mov(memb_a32[ss, ebp - 0x4], bl);       /* mov [ebp-0x4], bl */
            ii(0x1009_cacf, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1009_cad1, 3); mov(bl, memb_a32[ss, ebp - 0x4]);       /* mov bl, [ebp-0x4] */
            ii(0x1009_cad4, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1009_cad7, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1009_cada, 5); calld(0x1009_cb2c, 0x4d);               /* call 0x1009cb2c */
            ii(0x1009_cadf, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1009_cae2, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x1009_cae5, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1009_cae8, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1009_caeb, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1009_caee, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1009_caf1, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_caf3, 1); popd(ebp);                              /* pop ebp */
            ii(0x1009_caf4, 1); popd(edi);                              /* pop edi */
            ii(0x1009_caf5, 1); popd(esi);                              /* pop esi */
            ii(0x1009_caf6, 1); popd(ecx);                              /* pop ecx */
            ii(0x1009_caf7, 1); retd(); return;                         /* ret */
        }
    }
}
