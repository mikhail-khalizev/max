using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_7bed-36ee8185")]
        public void Method_100c_7bed()
        {
            ii(0x100c_7bed, 5); push(0x28);                             /* push 0x28 */
            ii(0x100c_7bf2, 5); call(Definitions.sys_check_available_stack_size, 0x9_e15b); /* call 0x10165d52 */
            ii(0x100c_7bf7, 1); push(ecx);                              /* push ecx */
            ii(0x100c_7bf8, 1); push(esi);                              /* push esi */
            ii(0x100c_7bf9, 1); push(edi);                              /* push edi */
            ii(0x100c_7bfa, 1); push(ebp);                              /* push ebp */
            ii(0x100c_7bfb, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_7bfd, 6); sub(esp, 0x14);                         /* sub esp, 0x14 */
            ii(0x100c_7c03, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x100c_7c06, 3); mov(memd[ss, ebp - 8], edx);            /* mov [ebp-0x8], edx */
            ii(0x100c_7c09, 3); mov(memd[ss, ebp - 4], ebx);            /* mov [ebp-0x4], ebx */
            ii(0x100c_7c0c, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100c_7c0f, 3); movsx(edx, memw[ds, eax]);              /* movsx edx, word [eax] */
            ii(0x100c_7c12, 3); shl(edx, 2);                            /* shl edx, 0x2 */
            ii(0x100c_7c15, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100c_7c18, 3); mov(eax, memd[ds, eax + 0x27]);         /* mov eax, [eax+0x27] */
            ii(0x100c_7c1b, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x100c_7c1d, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100c_7c20, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x100c_7c22, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100c_7c25, 2); mov(edx, memd[ds, edx]);                /* mov edx, [edx] */
            ii(0x100c_7c27, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100c_7c29, 1); dec(eax);                               /* dec eax */
            ii(0x100c_7c2a, 3); mov(memd[ss, ebp - 0x14], eax);         /* mov [ebp-0x14], eax */
        l_0x100c_7c2d:
            ii(0x100c_7c2d, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100c_7c30, 4); mov(ax, memw[ds, eax + 2]);             /* mov ax, [eax+0x2] */
            ii(0x100c_7c34, 4); cmp(ax, memw[ss, ebp - 4]);             /* cmp ax, [ebp-0x4] */
            ii(0x100c_7c38, 2); if(jle(0x100c_7c49, 0xf)) goto l_0x100c_7c49; /* jle 0x100c7c49 */
            ii(0x100c_7c3a, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x100c_7c3d, 2); mov(al, memb[ds, eax]);                 /* mov al, [eax] */
            ii(0x100c_7c3f, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100c_7c44, 3); cmp(eax, 2);                            /* cmp eax, 0x2 */
            ii(0x100c_7c47, 2); if(jz(0x100c_7c4b, 2)) goto l_0x100c_7c4b; /* jz 0x100c7c4b */
        l_0x100c_7c49:
            ii(0x100c_7c49, 2); jmp(0x100c_7c5a, 0xf); goto l_0x100c_7c5a; /* jmp 0x100c7c5a */
        l_0x100c_7c4b:
            ii(0x100c_7c4b, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x100c_7c4e, 3); dec(memd[ss, ebp - 0x14]);              /* dec dword [ebp-0x14] */
            ii(0x100c_7c51, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100c_7c54, 4); dec(memw[ds, eax + 2]);                 /* dec word [eax+0x2] */
            ii(0x100c_7c58, 2); jmp(0x100c_7c2d, -0x2d); goto l_0x100c_7c2d; /* jmp 0x100c7c2d */
        l_0x100c_7c5a:
            ii(0x100c_7c5a, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100c_7c5d, 4); mov(ax, memw[ds, eax + 2]);             /* mov ax, [eax+0x2] */
            ii(0x100c_7c61, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x100c_7c64, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x100c_7c67, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_7c69, 1); pop(ebp);                               /* pop ebp */
            ii(0x100c_7c6a, 1); pop(edi);                               /* pop edi */
            ii(0x100c_7c6b, 1); pop(esi);                               /* pop esi */
            ii(0x100c_7c6c, 1); pop(ecx);                               /* pop ecx */
            ii(0x100c_7c6d, 1); ret();                                  /* ret */
        }
    }
}
