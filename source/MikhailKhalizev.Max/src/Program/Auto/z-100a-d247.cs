using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_d247-3f058dcb")]
        public void Method_100a_d247()
        {
            ii(0x100a_d247, 5); push(0x28);                             /* push 0x28 */
            ii(0x100a_d24c, 5); call(Definitions.sys_check_available_stack_size, 0xb_8b01); /* call 0x10165d52 */
            ii(0x100a_d251, 1); push(ebx);                              /* push ebx */
            ii(0x100a_d252, 1); push(ecx);                              /* push ecx */
            ii(0x100a_d253, 1); push(edx);                              /* push edx */
            ii(0x100a_d254, 1); push(esi);                              /* push esi */
            ii(0x100a_d255, 1); push(edi);                              /* push edi */
            ii(0x100a_d256, 1); push(ebp);                              /* push ebp */
            ii(0x100a_d257, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_d259, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100a_d25f, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x100a_d262, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100a_d265, 3); mov(eax, memd[ds, eax + 36]);           /* mov eax, [eax+0x24] */
            ii(0x100a_d268, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100a_d26b, 3); cmp(eax, -1 /* 0xff */);                /* cmp eax, 0xffffffff */
            ii(0x100a_d26e, 2); if(jz(0x100a_d28e, 0x1e)) goto l_0x100a_d28e; /* jz 0x100ad28e */
            ii(0x100a_d270, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100a_d273, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100a_d276, 5); call(0x1007_6574, -0x3_6d07);           /* call 0x10076574 */
            ii(0x100a_d27b, 3); mov(edx, memd[ds, eax + 24]);           /* mov edx, [eax+0x18] */
            ii(0x100a_d27e, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100a_d281, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100a_d284, 3); mov(eax, memd[ds, eax + 28]);           /* mov eax, [eax+0x1c] */
            ii(0x100a_d287, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100a_d28a, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100a_d28c, 2); if(jz(0x100a_d290, 2)) goto l_0x100a_d290; /* jz 0x100ad290 */
        l_0x100a_d28e:
            ii(0x100a_d28e, 2); jmp(0x100a_d2ae, 0x1e); goto l_0x100a_d2ae; /* jmp 0x100ad2ae */
        l_0x100a_d290:
            ii(0x100a_d290, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100a_d293, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100a_d296, 5); call(0x1007_6574, -0x3_6d27);           /* call 0x10076574 */
            ii(0x100a_d29b, 3); mov(edx, memd[ds, eax + 26]);           /* mov edx, [eax+0x1a] */
            ii(0x100a_d29e, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100a_d2a1, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100a_d2a4, 3); mov(eax, memd[ds, eax + 30]);           /* mov eax, [eax+0x1e] */
            ii(0x100a_d2a7, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100a_d2aa, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100a_d2ac, 2); if(jz(0x100a_d2b0, 2)) goto l_0x100a_d2b0; /* jz 0x100ad2b0 */
        l_0x100a_d2ae:
            ii(0x100a_d2ae, 2); jmp(0x100a_d2b6, 6); goto l_0x100a_d2b6; /* jmp 0x100ad2b6 */
        l_0x100a_d2b0:
            ii(0x100a_d2b0, 4); mov(memb[ss, ebp - 8], 1);              /* mov byte [ebp-0x8], 0x1 */
            ii(0x100a_d2b4, 2); jmp(0x100a_d2ba, 4); goto l_0x100a_d2ba; /* jmp 0x100ad2ba */
        l_0x100a_d2b6:
            ii(0x100a_d2b6, 4); mov(memb[ss, ebp - 8], 0);              /* mov byte [ebp-0x8], 0x0 */
        l_0x100a_d2ba:
            ii(0x100a_d2ba, 3); mov(al, memb[ss, ebp - 8]);             /* mov al, [ebp-0x8] */
            ii(0x100a_d2bd, 3); mov(memb[ss, ebp - 12], al);            /* mov [ebp-0xc], al */
            ii(0x100a_d2c0, 3); mov(al, memb[ss, ebp - 12]);            /* mov al, [ebp-0xc] */
            ii(0x100a_d2c3, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_d2c5, 1); pop(ebp);                               /* pop ebp */
            ii(0x100a_d2c6, 1); pop(edi);                               /* pop edi */
            ii(0x100a_d2c7, 1); pop(esi);                               /* pop esi */
            ii(0x100a_d2c8, 1); pop(edx);                               /* pop edx */
            ii(0x100a_d2c9, 1); pop(ecx);                               /* pop ecx */
            ii(0x100a_d2ca, 1); pop(ebx);                               /* pop ebx */
            ii(0x100a_d2cb, 1); ret();                                  /* ret */
        }
    }
}
