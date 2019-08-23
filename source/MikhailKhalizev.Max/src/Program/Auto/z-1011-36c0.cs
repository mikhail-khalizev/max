using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1011_36c0-9fcb3782")]
        public void Method_1011_36c0()
        {
            ii(0x1011_36c0, 5); push(0x28);                             /* push 0x28 */
            ii(0x1011_36c5, 5); call(Definitions.sys_check_available_stack_size, 0x5_2688); /* call 0x10165d52 */
            ii(0x1011_36ca, 1); push(ebx);                              /* push ebx */
            ii(0x1011_36cb, 1); push(ecx);                              /* push ecx */
            ii(0x1011_36cc, 1); push(edx);                              /* push edx */
            ii(0x1011_36cd, 1); push(esi);                              /* push esi */
            ii(0x1011_36ce, 1); push(edi);                              /* push edi */
            ii(0x1011_36cf, 1); push(ebp);                              /* push ebp */
            ii(0x1011_36d0, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1011_36d2, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1011_36d8, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1011_36db, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_36de, 3); mov(al, memb[ds, eax + 0x11]);          /* mov al, [eax+0x11] */
            ii(0x1011_36e1, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1011_36e6, 5); cmp(eax, 0xff);                         /* cmp eax, 0xff */
            ii(0x1011_36eb, 2); if(jz(0x1011_36fd, 0x10)) goto l_0x1011_36fd; /* jz 0x101136fd */
            ii(0x1011_36ed, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_36f0, 3); mov(al, memb[ds, eax + 0xf]);           /* mov al, [eax+0xf] */
            ii(0x1011_36f3, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1011_36f8, 3); cmp(eax, 0x2);                          /* cmp eax, 0x2 */
            ii(0x1011_36fb, 2); if(jge(0x1011_3706, 0x9)) goto l_0x1011_3706; /* jge 0x10113706 */
        l_0x1011_36fd:
            ii(0x1011_36fd, 7); mov(memd[ss, ebp - 0xc], 0);            /* mov dword [ebp-0xc], 0x0 */
            ii(0x1011_3704, 2); jmp(0x1011_3755, 0x4f); goto l_0x1011_3755; /* jmp 0x10113755 */
        l_0x1011_3706:
            ii(0x1011_3706, 4); mov(memb[ss, ebp - 0x8], 0x4);          /* mov byte [ebp-0x8], 0x4 */
        l_0x1011_370a:
            ii(0x1011_370a, 3); dec(memb[ss, ebp - 0x8]);               /* dec byte [ebp-0x8] */
            ii(0x1011_370d, 4); cmp(memb[ss, ebp - 0x8], -0x1 /* 0xff */); /* cmp byte [ebp-0x8], 0xff */
            ii(0x1011_3711, 2); if(jz(0x1011_374e, 0x3b)) goto l_0x1011_374e; /* jz 0x1011374e */
            ii(0x1011_3713, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1011_3715, 3); mov(al, memb[ss, ebp - 0x8]);           /* mov al, [ebp-0x8] */
            ii(0x1011_3718, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x1011_371a, 3); add(eax, memd[ss, ebp - 0x4]);          /* add eax, [ebp-0x4] */
            ii(0x1011_371d, 6); mov(eax, memd[ds, eax + 0x4da]);        /* mov eax, [eax+0x4da] */
            ii(0x1011_3723, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1011_3726, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1011_3728, 2); if(jz(0x1011_3741, 0x17)) goto l_0x1011_3741; /* jz 0x10113741 */
            ii(0x1011_372a, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1011_372c, 3); mov(al, memb[ss, ebp - 0x8]);           /* mov al, [ebp-0x8] */
            ii(0x1011_372f, 3); add(eax, memd[ss, ebp - 0x4]);          /* add eax, [ebp-0x4] */
            ii(0x1011_3732, 6); mov(al, memb[ds, eax + 0x4ec]);         /* mov al, [eax+0x4ec] */
            ii(0x1011_3738, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1011_373d, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1011_373f, 2); if(jz(0x1011_3743, 0x2)) goto l_0x1011_3743; /* jz 0x10113743 */
        l_0x1011_3741:
            ii(0x1011_3741, 2); jmp(0x1011_374c, 0x9); goto l_0x1011_374c; /* jmp 0x1011374c */
        l_0x1011_3743:
            ii(0x1011_3743, 7); mov(memd[ss, ebp - 0xc], 0);            /* mov dword [ebp-0xc], 0x0 */
            ii(0x1011_374a, 2); jmp(0x1011_3755, 0x9); goto l_0x1011_3755; /* jmp 0x10113755 */
        l_0x1011_374c:
            ii(0x1011_374c, 2); jmp(0x1011_370a, -0x44); goto l_0x1011_370a; /* jmp 0x1011370a */
        l_0x1011_374e:
            ii(0x1011_374e, 7); mov(memd[ss, ebp - 0xc], 0x1);          /* mov dword [ebp-0xc], 0x1 */
        l_0x1011_3755:
            ii(0x1011_3755, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1011_3758, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1011_375a, 1); pop(ebp);                               /* pop ebp */
            ii(0x1011_375b, 1); pop(edi);                               /* pop edi */
            ii(0x1011_375c, 1); pop(esi);                               /* pop esi */
            ii(0x1011_375d, 1); pop(edx);                               /* pop edx */
            ii(0x1011_375e, 1); pop(ecx);                               /* pop ecx */
            ii(0x1011_375f, 1); pop(ebx);                               /* pop ebx */
            ii(0x1011_3760, 1); ret();                                  /* ret */
        }
    }
}
