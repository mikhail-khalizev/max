using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100e_2f92-f282106b")]
        public void Method_100e_2f92()
        {
            ii(0x100e_2f92, 5); push(0x40);                             /* push 0x40 */
            ii(0x100e_2f97, 5); call(Definitions.sys_check_available_stack_size, 0x8_2db6); /* call 0x10165d52 */
            ii(0x100e_2f9c, 1); push(ebx);                              /* push ebx */
            ii(0x100e_2f9d, 1); push(ecx);                              /* push ecx */
            ii(0x100e_2f9e, 1); push(esi);                              /* push esi */
            ii(0x100e_2f9f, 1); push(edi);                              /* push edi */
            ii(0x100e_2fa0, 1); push(ebp);                              /* push ebp */
            ii(0x100e_2fa1, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_2fa3, 6); sub(esp, 0x28);                         /* sub esp, 0x28 */
            ii(0x100e_2fa9, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100e_2fac, 3); mov(memd[ss, ebp - 0x4], edx);          /* mov [ebp-0x4], edx */
            ii(0x100e_2faf, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100e_2fb2, 5); call(0x1007_623c, -0x6_cd7b);           /* call 0x1007623c */
            ii(0x100e_2fb7, 3); mov(edx, memd[ds, eax + 0x8]);          /* mov edx, [eax+0x8] */
            ii(0x100e_2fba, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100e_2fbd, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100e_2fc0, 3); mov(al, memb[ds, eax + 0x4d]);          /* mov al, [eax+0x4d] */
            ii(0x100e_2fc3, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100e_2fc8, 2); cmp(eax, edx);                          /* cmp eax, edx */
            ii(0x100e_2fca, 2); if(jl(0x100e_2fd2, 0x6)) goto l_0x100e_2fd2; /* jl 0x100e2fd2 */
            ii(0x100e_2fcc, 4); mov(memb[ss, ebp - 0xc], 0);            /* mov byte [ebp-0xc], 0x0 */
            ii(0x100e_2fd0, 2); jmp(0x100e_3015, 0x43); goto l_0x100e_3015; /* jmp 0x100e3015 */
        l_0x100e_2fd2:
            ii(0x100e_2fd2, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x100e_2fd5, 5); call(0x1007_20b1, -0x7_0f29);           /* call 0x100720b1 */
            ii(0x100e_2fda, 3); lea(eax, ebp - 0x28);                   /* lea eax, [ebp-0x28] */
            ii(0x100e_2fdd, 5); call(0x1007_20b1, -0x7_0f31);           /* call 0x100720b1 */
            ii(0x100e_2fe2, 3); lea(ebx, ebp - 0x28);                   /* lea ebx, [ebp-0x28] */
            ii(0x100e_2fe5, 3); lea(edx, ebp - 0x1c);                   /* lea edx, [ebp-0x1c] */
            ii(0x100e_2fe8, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100e_2feb, 3); add(eax, 0x18);                         /* add eax, 0x18 */
            ii(0x100e_2fee, 5); call(0x1007_6574, -0x6_ca7f);           /* call 0x10076574 */
            ii(0x100e_2ff3, 5); call(0x1007_6204, -0x6_cdf4);           /* call 0x10076204 */
            ii(0x100e_2ff8, 5); call(0x1014_3616, 0x6_0619);            /* call 0x10143616 */
            ii(0x100e_2ffd, 4); movsx(eax, memw[ss, ebp - 0x1a]);       /* movsx eax, word [ebp-0x1a] */
            ii(0x100e_3001, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100e_3003, 2); if(jle(0x100e_300b, 0x6)) goto l_0x100e_300b; /* jle 0x100e300b */
            ii(0x100e_3005, 4); mov(memb[ss, ebp - 0x10], 0x1);         /* mov byte [ebp-0x10], 0x1 */
            ii(0x100e_3009, 2); jmp(0x100e_300f, 0x4); goto l_0x100e_300f; /* jmp 0x100e300f */
        l_0x100e_300b:
            ii(0x100e_300b, 4); mov(memb[ss, ebp - 0x10], 0);           /* mov byte [ebp-0x10], 0x0 */
        l_0x100e_300f:
            ii(0x100e_300f, 3); mov(al, memb[ss, ebp - 0x10]);          /* mov al, [ebp-0x10] */
            ii(0x100e_3012, 3); mov(memb[ss, ebp - 0xc], al);           /* mov [ebp-0xc], al */
        l_0x100e_3015:
            ii(0x100e_3015, 3); mov(al, memb[ss, ebp - 0xc]);           /* mov al, [ebp-0xc] */
            ii(0x100e_3018, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_301a, 1); pop(ebp);                               /* pop ebp */
            ii(0x100e_301b, 1); pop(edi);                               /* pop edi */
            ii(0x100e_301c, 1); pop(esi);                               /* pop esi */
            ii(0x100e_301d, 1); pop(ecx);                               /* pop ecx */
            ii(0x100e_301e, 1); pop(ebx);                               /* pop ebx */
            ii(0x100e_301f, 1); ret();                                  /* ret */
        }
    }
}
