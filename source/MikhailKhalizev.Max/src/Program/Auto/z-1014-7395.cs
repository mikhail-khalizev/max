using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1014_7395-987724a8")]
        public void Method_1014_7395()
        {
            ii(0x1014_7395, 5); push(0x24);                             /* push 0x24 */
            ii(0x1014_739a, 5); call(Definitions.sys_check_available_stack_size, 0x1_e9b3); /* call 0x10165d52 */
            ii(0x1014_739f, 1); push(ebx);                              /* push ebx */
            ii(0x1014_73a0, 1); push(ecx);                              /* push ecx */
            ii(0x1014_73a1, 1); push(edx);                              /* push edx */
            ii(0x1014_73a2, 1); push(esi);                              /* push esi */
            ii(0x1014_73a3, 1); push(edi);                              /* push edi */
            ii(0x1014_73a4, 1); push(ebp);                              /* push ebp */
            ii(0x1014_73a5, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_73a7, 6); sub(esp, 8);                            /* sub esp, 0x8 */
            ii(0x1014_73ad, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x1014_73b0, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_73b3, 4); mov(ax, memw[ds, eax + 14]);            /* mov ax, [eax+0xe] */
            ii(0x1014_73b7, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
        l_0x1014_73ba:
            ii(0x1014_73ba, 3); dec(memd[ss, ebp - 8]);                 /* dec dword [ebp-0x8] */
            ii(0x1014_73bd, 5); cmp(memw[ss, ebp - 8], -1 /* 0xff */);  /* cmp word [ebp-0x8], 0xffff */
            ii(0x1014_73c2, 2); if(jz(0x1014_73d5, 0x11)) goto l_0x1014_73d5; /* jz 0x101473d5 */
            ii(0x1014_73c4, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_73c7, 2); mov(edx, memd[ds, eax]);                /* mov edx, [eax] */
            ii(0x1014_73c9, 5); mov(eax, 0x20);                         /* mov eax, 0x20 */
            ii(0x1014_73ce, 5); call(/* sys */ 0x1017_29f1, 0x2_b61e);  /* call 0x101729f1 */
            ii(0x1014_73d3, 2); jmp(0x1014_73ba, -0x1b); goto l_0x1014_73ba; /* jmp 0x101473ba */
        l_0x1014_73d5:
            ii(0x1014_73d5, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_73d7, 1); pop(ebp);                               /* pop ebp */
            ii(0x1014_73d8, 1); pop(edi);                               /* pop edi */
            ii(0x1014_73d9, 1); pop(esi);                               /* pop esi */
            ii(0x1014_73da, 1); pop(edx);                               /* pop edx */
            ii(0x1014_73db, 1); pop(ecx);                               /* pop ecx */
            ii(0x1014_73dc, 1); pop(ebx);                               /* pop ebx */
            ii(0x1014_73dd, 1); ret();                                  /* ret */
        }
    }
}
