using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100f_e750-f9efce7b")]
        public void Method_100f_e750()
        {
            ii(0x100f_e750, 5); push(0x6c);                             /* push 0x6c */
            ii(0x100f_e755, 5); call(Definitions.sys_check_available_stack_size, 0x6_75f8); /* call 0x10165d52 */
            ii(0x100f_e75a, 1); push(ecx);                              /* push ecx */
            ii(0x100f_e75b, 1); push(esi);                              /* push esi */
            ii(0x100f_e75c, 1); push(edi);                              /* push edi */
            ii(0x100f_e75d, 1); push(ebp);                              /* push ebp */
            ii(0x100f_e75e, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100f_e760, 6); sub(esp, 0x4c);                         /* sub esp, 0x4c */
            ii(0x100f_e766, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x100f_e769, 3); mov(memb[ss, ebp - 8], dl);             /* mov [ebp-0x8], dl */
            ii(0x100f_e76c, 3); mov(memb[ss, ebp - 4], bl);             /* mov [ebp-0x4], bl */
            ii(0x100f_e76f, 3); mov(al, memb[ss, ebp - 0xc]);           /* mov al, [ebp-0xc] */
            ii(0x100f_e772, 5); mov(memb[ds, 0x101c_37c8], al);         /* mov [0x101c37c8], al */
            ii(0x100f_e777, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_e779, 5); call(0x100f_fa70, 0x12f2);              /* call 0x100ffa70 */
            ii(0x100f_e77e, 4); cmp(memb[ss, ebp - 8], 0xa);            /* cmp byte [ebp-0x8], 0xa */
            ii(0x100f_e782, 2); if(jnz(0x100f_e7aa, 0x26)) goto l_0x100f_e7aa; /* jnz 0x100fe7aa */
            ii(0x100f_e784, 5); mov(eax, 0x46);                         /* mov eax, 0x46 */
            ii(0x100f_e789, 5); call(0x1007_5fdc, -0x8_87b2);           /* call 0x10075fdc */
            ii(0x100f_e78e, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x100f_e791, 5); mov(al, memb[ds, 0x101c_391f]);         /* mov al, [0x101c391f] */
            ii(0x100f_e796, 5); mov(memb[ds, 0x101c_391e], al);         /* mov [0x101c391e], al */
            ii(0x100f_e79b, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_e79d, 5); mov(al, memb[ds, 0x101c_37da]);         /* mov al, [0x101c37da] */
            ii(0x100f_e7a2, 1); cwde();                                 /* cwde */
            ii(0x100f_e7a3, 5); call(0x100f_3800, -0xafa8);             /* call 0x100f3800 */
            ii(0x100f_e7a8, 2); jmp(0x100f_e7be, 0x14); goto l_0x100f_e7be; /* jmp 0x100fe7be */
        l_0x100f_e7aa:
            ii(0x100f_e7aa, 5); mov(eax, 0x46);                         /* mov eax, 0x46 */
            ii(0x100f_e7af, 5); call(0x1007_5fdc, -0x8_87d8);           /* call 0x10075fdc */
            ii(0x100f_e7b4, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x100f_e7b7, 7); mov(memb[ds, 0x101c_391e], 0xb);        /* mov byte [0x101c391e], 0xb */
        l_0x100f_e7be:
            ii(0x100f_e7be, 4); movsx(eax, memw[ss, ebp - 0x10]);       /* movsx eax, word [ebp-0x10] */
            ii(0x100f_e7c2, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100f_e7c4, 2); if(jnz(0x100f_e7e3, 0x1d)) goto l_0x100f_e7e3; /* jnz 0x100fe7e3 */
            ii(0x100f_e7c6, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_e7c8, 5); mov(al, memb[ds, 0x101c_37da]);         /* mov al, [0x101c37da] */
            ii(0x100f_e7cd, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x100f_e7d3, 6); mov(al, memb[ds, eax + 0x101c_a490]);   /* mov al, [eax+0x101ca490] */
            ii(0x100f_e7d9, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100f_e7de, 3); cmp(eax, 2);                            /* cmp eax, 0x2 */
            ii(0x100f_e7e1, 2); if(jz(0x100f_e7e5, 2)) goto l_0x100f_e7e5; /* jz 0x100fe7e5 */
        l_0x100f_e7e3:
            ii(0x100f_e7e3, 2); jmp(0x100f_e7ec, 7); goto l_0x100f_e7ec; /* jmp 0x100fe7ec */
        l_0x100f_e7e5:
            ii(0x100f_e7e5, 7); mov(memd[ss, ebp - 0x10], 0x2d);        /* mov dword [ebp-0x10], 0x2d */
        l_0x100f_e7ec:
            ii(0x100f_e7ec, 4); movsx(eax, memw[ss, ebp - 0xc]);        /* movsx eax, word [ebp-0xc] */
            ii(0x100f_e7f0, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x100f_e7f6, 6); mov(al, memb[ds, eax + 0x101c_a490]);   /* mov al, [eax+0x101ca490] */
            ii(0x100f_e7fc, 3); mov(memb[ss, ebp - 0x14], al);          /* mov [ebp-0x14], al */
            ii(0x100f_e7ff, 5); if(jmp_func(0x100f_e90c, 0x108)) return; /* jmp 0x100fe90c */
        }
    }
}
