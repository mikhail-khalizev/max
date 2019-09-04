using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_2abd-e9b6d47d")]
        public void Method_100c_2abd()
        {
            ii(0x100c_2abd, 5); push(0x20);                             /* push 0x20 */
            ii(0x100c_2ac2, 5); call(Definitions.sys_check_available_stack_size, 0xa_328b); /* call 0x10165d52 */
            ii(0x100c_2ac7, 1); push(ebx);                              /* push ebx */
            ii(0x100c_2ac8, 1); push(ecx);                              /* push ecx */
            ii(0x100c_2ac9, 1); push(esi);                              /* push esi */
            ii(0x100c_2aca, 1); push(edi);                              /* push edi */
            ii(0x100c_2acb, 1); push(ebp);                              /* push ebp */
            ii(0x100c_2acc, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_2ace, 6); sub(esp, 8);                            /* sub esp, 0x8 */
            ii(0x100c_2ad4, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100c_2ad7, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x100c_2ada, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100c_2add, 4); cmp(memd[ds, eax + 103], 0);            /* cmp dword [eax+0x67], 0x0 */
            ii(0x100c_2ae1, 2); if(jz(0x100c_2b09, 0x26)) goto l_0x100c_2b09; /* jz 0x100c2b09 */
            ii(0x100c_2ae3, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100c_2ae6, 3); movsx(eax, memw[ds, eax]);              /* movsx eax, word [eax] */
            ii(0x100c_2ae9, 3); shl(eax, 2);                            /* shl eax, 0x2 */
            ii(0x100c_2aec, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x100c_2aee, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100c_2af1, 3); mov(edx, memd[ds, eax + 103]);          /* mov edx, [eax+0x67] */
            ii(0x100c_2af4, 2); add(edx, ebx);                          /* add edx, ebx */
            ii(0x100c_2af6, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100c_2af9, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x100c_2afb, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100c_2afe, 2); mov(edx, memd[ds, edx]);                /* mov edx, [edx] */
            ii(0x100c_2b00, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100c_2b02, 3); movsx(eax, memb[ds, eax]);              /* movsx eax, byte [eax] */
            ii(0x100c_2b05, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100c_2b07, 2); if(jl(0x100c_2b0b, 2)) goto l_0x100c_2b0b; /* jl 0x100c2b0b */
        l_0x100c_2b09:
            ii(0x100c_2b09, 2); jmp(0x100c_2b2d, 0x22); goto l_0x100c_2b2d; /* jmp 0x100c2b2d */
        l_0x100c_2b0b:
            ii(0x100c_2b0b, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100c_2b0e, 3); movsx(eax, memw[ds, eax]);              /* movsx eax, word [eax] */
            ii(0x100c_2b11, 3); shl(eax, 2);                            /* shl eax, 0x2 */
            ii(0x100c_2b14, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x100c_2b16, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100c_2b19, 3); mov(edx, memd[ds, eax + 103]);          /* mov edx, [eax+0x67] */
            ii(0x100c_2b1c, 2); add(edx, ebx);                          /* add edx, ebx */
            ii(0x100c_2b1e, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100c_2b21, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x100c_2b23, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100c_2b26, 2); mov(edx, memd[ds, edx]);                /* mov edx, [edx] */
            ii(0x100c_2b28, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100c_2b2a, 3); mov(memb[ds, eax], 0);                  /* mov byte [eax], 0x0 */
        l_0x100c_2b2d:
            ii(0x100c_2b2d, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_2b2f, 1); pop(ebp);                               /* pop ebp */
            ii(0x100c_2b30, 1); pop(edi);                               /* pop edi */
            ii(0x100c_2b31, 1); pop(esi);                               /* pop esi */
            ii(0x100c_2b32, 1); pop(ecx);                               /* pop ecx */
            ii(0x100c_2b33, 1); pop(ebx);                               /* pop ebx */
            ii(0x100c_2b34, 1); ret();                                  /* ret */
        }
    }
}
