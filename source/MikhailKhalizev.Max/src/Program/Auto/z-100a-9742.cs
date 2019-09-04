using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_9742-59f2c38a")]
        public void Method_100a_9742()
        {
            ii(0x100a_9742, 5); push(0x28);                             /* push 0x28 */
            ii(0x100a_9747, 5); call(Definitions.sys_check_available_stack_size, 0xb_c606); /* call 0x10165d52 */
            ii(0x100a_974c, 1); push(ebx);                              /* push ebx */
            ii(0x100a_974d, 1); push(ecx);                              /* push ecx */
            ii(0x100a_974e, 1); push(edx);                              /* push edx */
            ii(0x100a_974f, 1); push(esi);                              /* push esi */
            ii(0x100a_9750, 1); push(edi);                              /* push edi */
            ii(0x100a_9751, 1); push(ebp);                              /* push ebp */
            ii(0x100a_9752, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_9754, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100a_975a, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x100a_975d, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100a_9760, 4); mov(ax, memw[ds, eax + 10]);            /* mov ax, [eax+0xa] */
            ii(0x100a_9764, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x100a_9767, 4); sub(ax, memw[ds, edx + 2]);             /* sub ax, [edx+0x2] */
            ii(0x100a_976b, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x100a_976d, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100a_9770, 4); mov(ax, memw[ds, eax + 10]);            /* mov ax, [eax+0xa] */
            ii(0x100a_9774, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x100a_9777, 4); sub(ax, memw[ds, edx + 2]);             /* sub ax, [edx+0x2] */
            ii(0x100a_977b, 3); imul(ebx, eax);                         /* imul ebx, eax */
            ii(0x100a_977e, 3); mov(memd[ss, ebp - 8], ebx);            /* mov [ebp-0x8], ebx */
            ii(0x100a_9781, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100a_9784, 3); mov(ax, memw[ds, eax]);                 /* mov ax, [eax] */
            ii(0x100a_9787, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x100a_978a, 4); sub(ax, memw[ds, edx + 4]);             /* sub ax, [edx+0x4] */
            ii(0x100a_978e, 3); mov(memd[ss, ebp - 12], eax);           /* mov [ebp-0xc], eax */
            ii(0x100a_9791, 2); jmp(0x100a_9799, 6); goto l_0x100a_9799; /* jmp 0x100a9799 */
        l_0x100a_9793:
            ii(0x100a_9793, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x100a_9796, 3); inc(memd[ss, ebp - 12]);                /* inc dword [ebp-0xc] */
        l_0x100a_9799:
            ii(0x100a_9799, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x100a_979c, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x100a_979f, 3); cmp(ax, memw[ds, edx]);                 /* cmp ax, [edx] */
            ii(0x100a_97a2, 2); if(jg(0x100a_97d4, 0x30)) goto l_0x100a_97d4; /* jg 0x100a97d4 */
            ii(0x100a_97a4, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100a_97a7, 3); movsx(eax, memw[ds, eax]);              /* movsx eax, word [eax] */
            ii(0x100a_97aa, 4); movsx(edx, memw[ss, ebp - 12]);         /* movsx edx, word [ebp-0xc] */
            ii(0x100a_97ae, 2); sub(edx, eax);                          /* sub edx, eax */
            ii(0x100a_97b0, 2); mov(ebx, edx);                          /* mov ebx, edx */
            ii(0x100a_97b2, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100a_97b5, 3); movsx(eax, memw[ds, eax]);              /* movsx eax, word [eax] */
            ii(0x100a_97b8, 4); movsx(edx, memw[ss, ebp - 12]);         /* movsx edx, word [ebp-0xc] */
            ii(0x100a_97bc, 2); sub(edx, eax);                          /* sub edx, eax */
            ii(0x100a_97be, 3); imul(edx, ebx);                         /* imul edx, ebx */
            ii(0x100a_97c1, 4); movsx(eax, memw[ss, ebp - 8]);          /* movsx eax, word [ebp-0x8] */
            ii(0x100a_97c5, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x100a_97c7, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100a_97ca, 3); mov(eax, memd[ds, eax + 4]);            /* mov eax, [eax+0x4] */
            ii(0x100a_97cd, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100a_97d0, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100a_97d2, 2); if(jg(0x100a_9793, -0x41)) goto l_0x100a_9793; /* jg 0x100a9793 */
        l_0x100a_97d4:
            ii(0x100a_97d4, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x100a_97d7, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x100a_97da, 4); mov(memw[ds, edx + 8], ax);             /* mov [edx+0x8], ax */
            ii(0x100a_97de, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100a_97e1, 3); mov(dx, memw[ds, eax]);                 /* mov dx, [eax] */
            ii(0x100a_97e4, 2); add(edx, edx);                          /* add edx, edx */
            ii(0x100a_97e6, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100a_97e9, 3); sub(edx, memd[ss, ebp - 12]);           /* sub edx, [ebp-0xc] */
            ii(0x100a_97ec, 4); mov(memw[ds, eax + 12], dx);            /* mov [eax+0xc], dx */
            ii(0x100a_97f0, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100a_97f3, 3); mov(eax, memd[ds, eax + 6]);            /* mov eax, [eax+0x6] */
            ii(0x100a_97f6, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100a_97f9, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100a_97fb, 2); if(jge(0x100a_9806, 9)) goto l_0x100a_9806; /* jge 0x100a9806 */
            ii(0x100a_97fd, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100a_9800, 6); mov(memw[ds, eax + 8], 0);              /* mov word [eax+0x8], 0x0 */
        l_0x100a_9806:
            ii(0x100a_9806, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100a_9809, 3); mov(edx, memd[ds, eax + 10]);           /* mov edx, [eax+0xa] */
            ii(0x100a_980c, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100a_980f, 5); mov(eax, memd[ds, 0x101c_8170]);        /* mov eax, [0x101c8170] */
            ii(0x100a_9814, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100a_9817, 1); dec(eax);                               /* dec eax */
            ii(0x100a_9818, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100a_981a, 2); if(jle(0x100a_982a, 0xe)) goto l_0x100a_982a; /* jle 0x100a982a */
            ii(0x100a_981c, 6); mov(ax, memw[ds, 0x101c_8172]);         /* mov ax, [0x101c8172] */
            ii(0x100a_9822, 1); dec(eax);                               /* dec eax */
            ii(0x100a_9823, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x100a_9826, 4); mov(memw[ds, edx + 12], ax);            /* mov [edx+0xc], ax */
        l_0x100a_982a:
            ii(0x100a_982a, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_982c, 1); pop(ebp);                               /* pop ebp */
            ii(0x100a_982d, 1); pop(edi);                               /* pop edi */
            ii(0x100a_982e, 1); pop(esi);                               /* pop esi */
            ii(0x100a_982f, 1); pop(edx);                               /* pop edx */
            ii(0x100a_9830, 1); pop(ecx);                               /* pop ecx */
            ii(0x100a_9831, 1); pop(ebx);                               /* pop ebx */
            ii(0x100a_9832, 1); ret();                                  /* ret */
        }
    }
}
