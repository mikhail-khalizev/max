using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100f_a9fd-88582dc5")]
        public void Method_100f_a9fd()
        {
            ii(0x100f_a9fd, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100f_aa02, 5); calld(Definitions.sys_check_available_stack_size, 0x6_b34b); /* call 0x10165d52 */
            ii(0x100f_aa07, 1); pushd(ebx);                             /* push ebx */
            ii(0x100f_aa08, 1); pushd(ecx);                             /* push ecx */
            ii(0x100f_aa09, 1); pushd(edx);                             /* push edx */
            ii(0x100f_aa0a, 1); pushd(esi);                             /* push esi */
            ii(0x100f_aa0b, 1); pushd(edi);                             /* push edi */
            ii(0x100f_aa0c, 1); pushd(ebp);                             /* push ebp */
            ii(0x100f_aa0d, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100f_aa0f, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100f_aa15, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100f_aa18, 5); mov(eax, 0x2);                          /* mov eax, 0x2 */
            ii(0x100f_aa1d, 5); calld(0x100e_883d, -0x1_21e5);          /* call 0x100e883d */
            ii(0x100f_aa22, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100f_aa25, 6); mov(edx, memd_a32[ds, 0x101c_38ec]);    /* mov edx, [0x101c38ec] */
            ii(0x100f_aa2b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100f_aa2e, 2); mov(memd_a32[ds, eax], edx);            /* mov [eax], edx */
            ii(0x100f_aa30, 7); imul(eax, memd_a32[ds, 0x101c_38c4], 0xa); /* imul eax, [0x101c38c4], 0xa */
            ii(0x100f_aa37, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100f_aa3a, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100f_aa3c, 5); mov(eax, memd_a32[ds, 0x101c_38f0]);    /* mov eax, [0x101c38f0] */
            ii(0x100f_aa41, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100f_aa43, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100f_aa46, 3); mov(memd_a32[ds, edx + 0x4], eax);      /* mov [edx+0x4], eax */
            ii(0x100f_aa49, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100f_aa4c, 3); mov(eax, memd_a32[ds, eax + 0x8]);      /* mov eax, [eax+0x8] */
            ii(0x100f_aa4f, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100f_aa52, 2); sub(eax, memd_a32[ds, edx]);            /* sub eax, [edx] */
            ii(0x100f_aa54, 1); inc(eax);                               /* inc eax */
            ii(0x100f_aa55, 7); imul(eax, memd_a32[ds, 0x101c_38c4]);   /* imul eax, [0x101c38c4] */
            ii(0x100f_aa5c, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100f_aa5f, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x100f_aa61, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100f_aa64, 2); mov(edx, memd_a32[ds, eax]);            /* mov edx, [eax] */
            ii(0x100f_aa66, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100f_aa69, 2); add(ebx, edx);                          /* add ebx, edx */
            ii(0x100f_aa6b, 3); mov(memd_a32[ds, eax + 0x8], ebx);      /* mov [eax+0x8], ebx */
            ii(0x100f_aa6e, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100f_aa71, 3); mov(eax, memd_a32[ds, eax + 0xc]);      /* mov eax, [eax+0xc] */
            ii(0x100f_aa74, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100f_aa77, 3); sub(eax, memd_a32[ds, edx + 0x4]);      /* sub eax, [edx+0x4] */
            ii(0x100f_aa7a, 1); inc(eax);                               /* inc eax */
            ii(0x100f_aa7b, 7); imul(eax, memd_a32[ds, 0x101c_38c4]);   /* imul eax, [0x101c38c4] */
            ii(0x100f_aa82, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100f_aa85, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x100f_aa87, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100f_aa8a, 3); mov(edx, memd_a32[ds, eax + 0x4]);      /* mov edx, [eax+0x4] */
            ii(0x100f_aa8d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100f_aa90, 2); add(ebx, edx);                          /* add ebx, edx */
            ii(0x100f_aa92, 3); mov(memd_a32[ds, eax + 0xc], ebx);      /* mov [eax+0xc], ebx */
            ii(0x100f_aa95, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100f_aa97, 1); popd(ebp);                              /* pop ebp */
            ii(0x100f_aa98, 1); popd(edi);                              /* pop edi */
            ii(0x100f_aa99, 1); popd(esi);                              /* pop esi */
            ii(0x100f_aa9a, 1); popd(edx);                              /* pop edx */
            ii(0x100f_aa9b, 1); popd(ecx);                              /* pop ecx */
            ii(0x100f_aa9c, 1); popd(ebx);                              /* pop ebx */
            ii(0x100f_aa9d, 1); retd();                                 /* ret */
        }
    }
}
