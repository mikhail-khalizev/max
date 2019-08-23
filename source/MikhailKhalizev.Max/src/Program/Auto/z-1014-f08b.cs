using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1014_f08b-47b8e202")]
        public void Method_1014_f08b()
        {
            ii(0x1014_f08b, 5); push(0x20);                             /* push 0x20 */
            ii(0x1014_f090, 5); call(Definitions.sys_check_available_stack_size, 0x1_6cbd); /* call 0x10165d52 */
            ii(0x1014_f095, 1); push(ebx);                              /* push ebx */
            ii(0x1014_f096, 1); push(ecx);                              /* push ecx */
            ii(0x1014_f097, 1); push(edx);                              /* push edx */
            ii(0x1014_f098, 1); push(esi);                              /* push esi */
            ii(0x1014_f099, 1); push(edi);                              /* push edi */
            ii(0x1014_f09a, 1); push(ebp);                              /* push ebp */
            ii(0x1014_f09b, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_f09d, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x1014_f0a3, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1014_f0a6, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_f0a9, 3); mov(dl, memb[ds, eax + 0x3f]);          /* mov dl, [eax+0x3f] */
            ii(0x1014_f0ac, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_f0af, 3); cmp(dl, memb[ds, eax + 0x3d]);          /* cmp dl, [eax+0x3d] */
            ii(0x1014_f0b2, 2); if(jnz(0x1014_f0be, 0xa)) goto l_0x1014_f0be; /* jnz 0x1014f0be */
            ii(0x1014_f0b4, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_f0b7, 5); cmp(memw[ds, eax + 0x8], 0);            /* cmp word [eax+0x8], 0x0 */
            ii(0x1014_f0bc, 2); if(jnz(0x1014_f0c0, 0x2)) goto l_0x1014_f0c0; /* jnz 0x1014f0c0 */
        l_0x1014_f0be:
            ii(0x1014_f0be, 2); jmp(0x1014_f0ca, 0xa); goto l_0x1014_f0ca; /* jmp 0x1014f0ca */
        l_0x1014_f0c0:
            ii(0x1014_f0c0, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_f0c3, 5); cmp(memw[ds, eax + 0x8], 0x28);         /* cmp word [eax+0x8], 0x28 */
            ii(0x1014_f0c8, 2); if(jnz(0x1014_f0cc, 0x2)) goto l_0x1014_f0cc; /* jnz 0x1014f0cc */
        l_0x1014_f0ca:
            ii(0x1014_f0ca, 2); jmp(0x1014_f0d6, 0xa); goto l_0x1014_f0d6; /* jmp 0x1014f0d6 */
        l_0x1014_f0cc:
            ii(0x1014_f0cc, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_f0cf, 5); cmp(memw[ds, eax + 0x8], 0x1c);         /* cmp word [eax+0x8], 0x1c */
            ii(0x1014_f0d4, 2); if(jnz(0x1014_f0d8, 0x2)) goto l_0x1014_f0d8; /* jnz 0x1014f0d8 */
        l_0x1014_f0d6:
            ii(0x1014_f0d6, 2); jmp(0x1014_f0e2, 0xa); goto l_0x1014_f0e2; /* jmp 0x1014f0e2 */
        l_0x1014_f0d8:
            ii(0x1014_f0d8, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_f0db, 5); cmp(memw[ds, eax + 0x8], 0x2);          /* cmp word [eax+0x8], 0x2 */
            ii(0x1014_f0e0, 2); if(jnz(0x1014_f0e4, 0x2)) goto l_0x1014_f0e4; /* jnz 0x1014f0e4 */
        l_0x1014_f0e2:
            ii(0x1014_f0e2, 2); jmp(0x1014_f0ee, 0xa); goto l_0x1014_f0ee; /* jmp 0x1014f0ee */
        l_0x1014_f0e4:
            ii(0x1014_f0e4, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_f0e7, 5); cmp(memw[ds, eax + 0x8], 0x1);          /* cmp word [eax+0x8], 0x1 */
            ii(0x1014_f0ec, 2); if(jnz(0x1014_f0f0, 0x2)) goto l_0x1014_f0f0; /* jnz 0x1014f0f0 */
        l_0x1014_f0ee:
            ii(0x1014_f0ee, 2); jmp(0x1014_f0fa, 0xa); goto l_0x1014_f0fa; /* jmp 0x1014f0fa */
        l_0x1014_f0f0:
            ii(0x1014_f0f0, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_f0f3, 5); cmp(memw[ds, eax + 0x8], 0x1d);         /* cmp word [eax+0x8], 0x1d */
            ii(0x1014_f0f8, 2); if(jnz(0x1014_f0fc, 0x2)) goto l_0x1014_f0fc; /* jnz 0x1014f0fc */
        l_0x1014_f0fa:
            ii(0x1014_f0fa, 2); jmp(0x1014_f10a, 0xe); goto l_0x1014_f10a; /* jmp 0x1014f10a */
        l_0x1014_f0fc:
            ii(0x1014_f0fc, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_f0ff, 4); mov(memb[ds, eax + 0x3f], 0);           /* mov byte [eax+0x3f], 0x0 */
            ii(0x1014_f103, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_f106, 4); mov(memb[ds, eax + 0x40], 0x1);         /* mov byte [eax+0x40], 0x1 */
        l_0x1014_f10a:
            ii(0x1014_f10a, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_f10d, 3); mov(dl, memb[ds, eax + 0x3f]);          /* mov dl, [eax+0x3f] */
            ii(0x1014_f110, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_f113, 3); mov(memb[ds, eax + 0x3d], dl);          /* mov [eax+0x3d], dl */
            ii(0x1014_f116, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_f119, 3); mov(dl, memb[ds, eax + 0x40]);          /* mov dl, [eax+0x40] */
            ii(0x1014_f11c, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_f11f, 3); mov(memb[ds, eax + 0x3e], dl);          /* mov [eax+0x3e], dl */
            ii(0x1014_f122, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_f124, 1); pop(ebp);                               /* pop ebp */
            ii(0x1014_f125, 1); pop(edi);                               /* pop edi */
            ii(0x1014_f126, 1); pop(esi);                               /* pop esi */
            ii(0x1014_f127, 1); pop(edx);                               /* pop edx */
            ii(0x1014_f128, 1); pop(ecx);                               /* pop ecx */
            ii(0x1014_f129, 1); pop(ebx);                               /* pop ebx */
            ii(0x1014_f12a, 1); ret();                                  /* ret */
        }
    }
}
