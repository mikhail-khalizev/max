using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1017_915c-428f592")]
        public void /* sys */ sys_strncmp()
        {
            ii(0x1017_915c, 1); push(ecx);                              /* push ecx */
        l_0x1017_915d:
            ii(0x1017_915d, 2); test(ebx, ebx);                         /* test ebx, ebx */
            ii(0x1017_915f, 2); if(jnz(0x1017_9165, 4)) goto l_0x1017_9165; /* jnz 0x10179165 */
        l_0x1017_9161:
            ii(0x1017_9161, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1017_9163, 1); pop(ecx);                               /* pop ecx */
            ii(0x1017_9164, 1); ret(); return;                          /* ret */
        l_0x1017_9165:
            ii(0x1017_9165, 2); mov(cl, memb[ds, eax]);                 /* mov cl, [eax] */
            ii(0x1017_9167, 2); mov(ch, memb[ds, edx]);                 /* mov ch, [edx] */
            ii(0x1017_9169, 2); cmp(cl, ch);                            /* cmp cl, ch */
            ii(0x1017_916b, 2); if(jz(0x1017_917b, 0xe)) goto l_0x1017_917b; /* jz 0x1017917b */
            ii(0x1017_916d, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1017_916f, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1017_9171, 2); mov(bl, cl);                            /* mov bl, cl */
            ii(0x1017_9173, 2); mov(al, ch);                            /* mov al, ch */
            ii(0x1017_9175, 2); sub(ebx, eax);                          /* sub ebx, eax */
            ii(0x1017_9177, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1017_9179, 1); pop(ecx);                               /* pop ecx */
            ii(0x1017_917a, 1); ret(); return;                          /* ret */
        l_0x1017_917b:
            ii(0x1017_917b, 3); cmp(memb[ds, eax], 0);                  /* cmp byte [eax], 0x0 */
            ii(0x1017_917e, 2); if(jz(0x1017_9161, -0x1f)) goto l_0x1017_9161; /* jz 0x10179161 */
            ii(0x1017_9180, 1); inc(eax);                               /* inc eax */
            ii(0x1017_9181, 1); inc(edx);                               /* inc edx */
            ii(0x1017_9182, 1); dec(ebx);                               /* dec ebx */
            ii(0x1017_9183, 2); jmp(0x1017_915d, -0x28); goto l_0x1017_915d; /* jmp 0x1017915d */
        }
    }
}
