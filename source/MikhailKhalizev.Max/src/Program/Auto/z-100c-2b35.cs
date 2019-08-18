using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("7d7d4ec7-cb4f-4387-a88b-cffe67317603")]
        public void Method_100c_2b35()
        {
            ii(0x100c_2b35, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x100c_2b3a, 5); calld(Definitions.sys_check_available_stack_size, 0xa_3213); /* call 0x10165d52 */
            ii(0x100c_2b3f, 1); pushd(ebx);                             /* push ebx */
            ii(0x100c_2b40, 1); pushd(ecx);                             /* push ecx */
            ii(0x100c_2b41, 1); pushd(esi);                             /* push esi */
            ii(0x100c_2b42, 1); pushd(edi);                             /* push edi */
            ii(0x100c_2b43, 1); pushd(ebp);                             /* push ebp */
            ii(0x100c_2b44, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_2b46, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100c_2b4c, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100c_2b4f, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100c_2b52, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_2b55, 4); cmp(memd_a32[ds, eax + 0x67], 0);       /* cmp dword [eax+0x67], 0x0 */
            ii(0x100c_2b59, 2); if(jzd(0x100c_2b7d, 0x22)) goto l_0x100c_2b7d; /* jz 0x100c2b7d */
            ii(0x100c_2b5b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100c_2b5e, 3); movsx(eax, memw_a32[ds, eax]);          /* movsx eax, word [eax] */
            ii(0x100c_2b61, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x100c_2b64, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x100c_2b66, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_2b69, 3); mov(edx, memd_a32[ds, eax + 0x67]);     /* mov edx, [eax+0x67] */
            ii(0x100c_2b6c, 2); add(edx, ebx);                          /* add edx, ebx */
            ii(0x100c_2b6e, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100c_2b71, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x100c_2b73, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100c_2b76, 2); mov(edx, memd_a32[ds, edx]);            /* mov edx, [edx] */
            ii(0x100c_2b78, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100c_2b7a, 3); mov(memb_a32[ds, eax], 0xff);           /* mov byte [eax], 0xff */
        l_0x100c_2b7d:
            ii(0x100c_2b7d, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_2b7f, 1); popd(ebp);                              /* pop ebp */
            ii(0x100c_2b80, 1); popd(edi);                              /* pop edi */
            ii(0x100c_2b81, 1); popd(esi);                              /* pop esi */
            ii(0x100c_2b82, 1); popd(ecx);                              /* pop ecx */
            ii(0x100c_2b83, 1); popd(ebx);                              /* pop ebx */
            ii(0x100c_2b84, 1); retd(); return;                         /* ret */
        }
    }
}
