using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100f_ef80-293270b4")]
        public void Method_100f_ef80()
        {
            ii(0x100f_ef80, 5); push(0x2c);                             /* push 0x2c */
            ii(0x100f_ef85, 5); call(Definitions.sys_check_available_stack_size, 0x6_6dc8); /* call 0x10165d52 */
            ii(0x100f_ef8a, 1); push(ebx);                              /* push ebx */
            ii(0x100f_ef8b, 1); push(ecx);                              /* push ecx */
            ii(0x100f_ef8c, 1); push(edx);                              /* push edx */
            ii(0x100f_ef8d, 1); push(esi);                              /* push esi */
            ii(0x100f_ef8e, 1); push(edi);                              /* push edi */
            ii(0x100f_ef8f, 1); push(ebp);                              /* push ebp */
            ii(0x100f_ef90, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100f_ef92, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x100f_ef98, 5); mov(eax, memd[ds, 0x101c_3964]);        /* mov eax, [0x101c3964] */
            ii(0x100f_ef9d, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100f_efa0, 3); cmp(eax, 0x1);                          /* cmp eax, 0x1 */
            ii(0x100f_efa3, 2); if(jz(0x100f_efb1, 0xc)) goto l_0x100f_efb1; /* jz 0x100fefb1 */
            ii(0x100f_efa5, 7); mov(memd[ss, ebp - 0x4], 0);            /* mov dword [ebp-0x4], 0x0 */
            ii(0x100f_efac, 5); jmp(0x100f_f03d, 0x8c); goto l_0x100f_f03d; /* jmp 0x100ff03d */
        l_0x100f_efb1:
            ii(0x100f_efb1, 7); mov(memd[ss, ebp - 0xc], 0);            /* mov dword [ebp-0xc], 0x0 */
            ii(0x100f_efb8, 7); mov(memd[ss, ebp - 0x10], 0);           /* mov dword [ebp-0x10], 0x0 */
            ii(0x100f_efbf, 7); mov(memd[ss, ebp - 0x8], 0x4);          /* mov dword [ebp-0x8], 0x4 */
        l_0x100f_efc6:
            ii(0x100f_efc6, 3); dec(memd[ss, ebp - 0x8]);               /* dec dword [ebp-0x8] */
            ii(0x100f_efc9, 5); cmp(memw[ss, ebp - 0x8], -0x1 /* 0xff */); /* cmp word [ebp-0x8], 0xffff */
            ii(0x100f_efce, 2); if(jz(0x100f_f037, 0x67)) goto l_0x100f_f037; /* jz 0x100ff037 */
            ii(0x100f_efd0, 4); movsx(eax, memw[ss, ebp - 0x8]);        /* movsx eax, word [ebp-0x8] */
            ii(0x100f_efd4, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x100f_efda, 6); mov(al, memb[ds, eax + 0x101c_a490]);   /* mov al, [eax+0x101ca490] */
            ii(0x100f_efe0, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100f_efe5, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100f_efe7, 2); if(jz(0x100f_f003, 0x1a)) goto l_0x100f_f003; /* jz 0x100ff003 */
            ii(0x100f_efe9, 4); movsx(eax, memw[ss, ebp - 0x8]);        /* movsx eax, word [ebp-0x8] */
            ii(0x100f_efed, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x100f_eff3, 6); mov(al, memb[ds, eax + 0x101c_a490]);   /* mov al, [eax+0x101ca490] */
            ii(0x100f_eff9, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100f_effe, 3); cmp(eax, 0x4);                          /* cmp eax, 0x4 */
            ii(0x100f_f001, 2); if(jnz(0x100f_f005, 0x2)) goto l_0x100f_f005; /* jnz 0x100ff005 */
        l_0x100f_f003:
            ii(0x100f_f003, 2); jmp(0x100f_f01a, 0x15); goto l_0x100f_f01a; /* jmp 0x100ff01a */
        l_0x100f_f005:
            ii(0x100f_f005, 4); movsx(eax, memw[ss, ebp - 0x8]);        /* movsx eax, word [ebp-0x8] */
            ii(0x100f_f009, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x100f_f00f, 6); mov(eax, memd[ds, eax + 0x101c_a550]);  /* mov eax, [eax+0x101ca550] */
            ii(0x100f_f015, 3); cmp(eax, memd[ss, ebp - 0x10]);         /* cmp eax, [ebp-0x10] */
            ii(0x100f_f018, 2); if(jge(0x100f_f01c, 0x2)) goto l_0x100f_f01c; /* jge 0x100ff01c */
        l_0x100f_f01a:
            ii(0x100f_f01a, 2); jmp(0x100f_f035, 0x19); goto l_0x100f_f035; /* jmp 0x100ff035 */
        l_0x100f_f01c:
            ii(0x100f_f01c, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100f_f01f, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x100f_f022, 4); movsx(eax, memw[ss, ebp - 0x8]);        /* movsx eax, word [ebp-0x8] */
            ii(0x100f_f026, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x100f_f02c, 6); mov(eax, memd[ds, eax + 0x101c_a550]);  /* mov eax, [eax+0x101ca550] */
            ii(0x100f_f032, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
        l_0x100f_f035:
            ii(0x100f_f035, 2); jmp(0x100f_efc6, -0x71); goto l_0x100f_efc6; /* jmp 0x100fefc6 */
        l_0x100f_f037:
            ii(0x100f_f037, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100f_f03a, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
        l_0x100f_f03d:
            ii(0x100f_f03d, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100f_f040, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100f_f042, 1); pop(ebp);                               /* pop ebp */
            ii(0x100f_f043, 1); pop(edi);                               /* pop edi */
            ii(0x100f_f044, 1); pop(esi);                               /* pop esi */
            ii(0x100f_f045, 1); pop(edx);                               /* pop edx */
            ii(0x100f_f046, 1); pop(ecx);                               /* pop ecx */
            ii(0x100f_f047, 1); pop(ebx);                               /* pop ebx */
            ii(0x100f_f048, 1); ret();                                  /* ret */
        }
    }
}
