using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100f_927b-358e638b")]
        public void Method_100f_927b()
        {
            ii(0x100f_927b, 5); push(0x20);                             /* push 0x20 */
            ii(0x100f_9280, 5); call(Definitions.sys_check_available_stack_size, 0x6_cacd); /* call 0x10165d52 */
            ii(0x100f_9285, 1); push(esi);                              /* push esi */
            ii(0x100f_9286, 1); push(edi);                              /* push edi */
            ii(0x100f_9287, 1); push(ebp);                              /* push ebp */
            ii(0x100f_9288, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100f_928a, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x100f_9290, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x100f_9293, 3); mov(memd[ss, ebp - 0xc], edx);          /* mov [ebp-0xc], edx */
            ii(0x100f_9296, 3); mov(memd[ss, ebp - 0x8], ebx);          /* mov [ebp-0x8], ebx */
            ii(0x100f_9299, 3); mov(memd[ss, ebp - 0x4], ecx);          /* mov [ebp-0x4], ecx */
            ii(0x100f_929c, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x100f_929f, 3); cmp(eax, memd[ss, ebp - 0xc]);          /* cmp eax, [ebp-0xc] */
            ii(0x100f_92a2, 2); if(jnz(0x100f_92e4, 0x40)) goto l_0x100f_92e4; /* jnz 0x100f92e4 */
            ii(0x100f_92a4, 4); movsx(ebx, memw[ss, ebp - 0x4]);        /* movsx ebx, word [ebp-0x4] */
            ii(0x100f_92a8, 4); movsx(edx, memw[ss, ebp - 0x8]);        /* movsx edx, word [ebp-0x8] */
            ii(0x100f_92ac, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x100f_92af, 5); call(0x1007_284b, -0x8_6a69);           /* call 0x1007284b */
            ii(0x100f_92b4, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x100f_92b7, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x100f_92ba, 3); cmp(eax, memd[ss, ebp - 0xc]);          /* cmp eax, [ebp-0xc] */
            ii(0x100f_92bd, 2); if(jz(0x100f_92c5, 0x6)) goto l_0x100f_92c5; /* jz 0x100f92c5 */
            ii(0x100f_92bf, 4); cmp(memd[ss, ebp - 0xc], 0);            /* cmp dword [ebp-0xc], 0x0 */
            ii(0x100f_92c3, 2); if(jnz(0x100f_92c7, 0x2)) goto l_0x100f_92c7; /* jnz 0x100f92c7 */
        l_0x100f_92c5:
            ii(0x100f_92c5, 2); jmp(0x100f_92e2, 0x1b); goto l_0x100f_92e2; /* jmp 0x100f92e2 */
        l_0x100f_92c7:
            ii(0x100f_92c7, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_92c9, 5); mov(al, memb[ds, 0x101c_37da]);         /* mov al, [0x101c37da] */
            ii(0x100f_92ce, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100f_92d1, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100f_92d4, 5); call(0x1007_6074, -0x8_3265);           /* call 0x10076074 */
            ii(0x100f_92d9, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100f_92de, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100f_92e0, 2); if(jnz(0x100f_92e4, 0x2)) goto l_0x100f_92e4; /* jnz 0x100f92e4 */
        l_0x100f_92e2:
            ii(0x100f_92e2, 2); jmp(0x100f_92f8, 0x14); goto l_0x100f_92f8; /* jmp 0x100f92f8 */
        l_0x100f_92e4:
            ii(0x100f_92e4, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_92e6, 5); call(0x100f_448c, -0x4e5f);             /* call 0x100f448c */
            ii(0x100f_92eb, 5); call(0x100f_f5c1, 0x62d1);              /* call 0x100ff5c1 */
            ii(0x100f_92f0, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100f_92f3, 5); call(0x100f_f637, 0x633f);              /* call 0x100ff637 */
        l_0x100f_92f8:
            ii(0x100f_92f8, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100f_92fa, 1); pop(ebp);                               /* pop ebp */
            ii(0x100f_92fb, 1); pop(edi);                               /* pop edi */
            ii(0x100f_92fc, 1); pop(esi);                               /* pop esi */
            ii(0x100f_92fd, 1); ret();                                  /* ret */
        }
    }
}
