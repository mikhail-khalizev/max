using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1010_50a2-b6c9ffc2")]
        public void Method_1010_50a2()
        {
            ii(0x1010_50a2, 5); push(0x34);                             /* push 0x34 */
            ii(0x1010_50a7, 5); call(Definitions.sys_check_available_stack_size, 0x6_0ca6); /* call 0x10165d52 */
            ii(0x1010_50ac, 1); push(ecx);                              /* push ecx */
            ii(0x1010_50ad, 1); push(esi);                              /* push esi */
            ii(0x1010_50ae, 1); push(edi);                              /* push edi */
            ii(0x1010_50af, 1); push(ebp);                              /* push ebp */
            ii(0x1010_50b0, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1010_50b2, 6); sub(esp, 0x20);                         /* sub esp, 0x20 */
            ii(0x1010_50b8, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1010_50bb, 3); mov(memd[ss, ebp - 8], edx);            /* mov [ebp-0x8], edx */
            ii(0x1010_50be, 3); mov(memd[ss, ebp - 4], ebx);            /* mov [ebp-0x4], ebx */
        l_0x1010_50c1:
            ii(0x1010_50c1, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1010_50c4, 5); call(0x1010_4f1b, -0x1ae);              /* call 0x10104f1b */
            ii(0x1010_50c9, 2); test(al, al);                           /* test al, al */
            ii(0x1010_50cb, 2); if(jnz(0x1010_50d6, 9)) goto l_0x1010_50d6; /* jnz 0x101050d6 */
            ii(0x1010_50cd, 4); mov(memb[ss, ebp - 0x10], 0);           /* mov byte [ebp-0x10], 0x0 */
            ii(0x1010_50d1, 5); jmp(0x1010_5146, 0x70); goto l_0x1010_5146; /* jmp 0x10105146 */
        l_0x1010_50d6:
            ii(0x1010_50d6, 5); mov(edx, StringDefinitions.Control22);  /* mov edx, 0x101a32ea */
            ii(0x1010_50db, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1010_50de, 3); add(eax, 0x6f);                         /* add eax, 0x6f */
            ii(0x1010_50e1, 5); call(Definitions.sys_strstr, 0x7_3f2a); /* call 0x10179010 */
            ii(0x1010_50e6, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1010_50e8, 2); if(jz(0x1010_50f0, 6)) goto l_0x1010_50f0; /* jz 0x101050f0 */
            ii(0x1010_50ea, 4); mov(memb[ss, ebp - 0x10], 0);           /* mov byte [ebp-0x10], 0x0 */
            ii(0x1010_50ee, 2); jmp(0x1010_5146, 0x56); goto l_0x1010_5146; /* jmp 0x10105146 */
        l_0x1010_50f0:
            ii(0x1010_50f0, 5); mov(edx, StringDefinitions.Control23);  /* mov edx, 0x101a32ec */
            ii(0x1010_50f5, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1010_50f8, 3); add(eax, 0x6f);                         /* add eax, 0x6f */
            ii(0x1010_50fb, 5); call(Definitions.sys_strstr, 0x7_3f10); /* call 0x10179010 */
            ii(0x1010_5100, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1010_5102, 2); if(jz(0x1010_5141, 0x3d)) goto l_0x1010_5141; /* jz 0x10105141 */
            ii(0x1010_5104, 3); lea(ebx, memd[ss, ebp - 0x20]);         /* lea ebx, [ebp-0x20] */
            ii(0x1010_5107, 3); mov(edx, memd[ss, ebp - 0xc]);          /* mov edx, [ebp-0xc] */
            ii(0x1010_510a, 3); add(edx, 0x6f);                         /* add edx, 0x6f */
            ii(0x1010_510d, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1010_5110, 5); call(0x1010_5011, -0x104);              /* call 0x10105011 */
            ii(0x1010_5115, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1010_5118, 3); cmp(eax, memd[ss, ebp - 0x20]);         /* cmp eax, [ebp-0x20] */
            ii(0x1010_511b, 2); if(jl(0x1010_5125, 8)) goto l_0x1010_5125; /* jl 0x10105125 */
            ii(0x1010_511d, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1010_5120, 3); cmp(eax, memd[ss, ebp - 0x18]);         /* cmp eax, [ebp-0x18] */
            ii(0x1010_5123, 2); if(jle(0x1010_5127, 2)) goto l_0x1010_5127; /* jle 0x10105127 */
        l_0x1010_5125:
            ii(0x1010_5125, 2); jmp(0x1010_512f, 8); goto l_0x1010_512f; /* jmp 0x1010512f */
        l_0x1010_5127:
            ii(0x1010_5127, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1010_512a, 3); cmp(eax, memd[ss, ebp - 0x1c]);         /* cmp eax, [ebp-0x1c] */
            ii(0x1010_512d, 2); if(jge(0x1010_5131, 2)) goto l_0x1010_5131; /* jge 0x10105131 */
        l_0x1010_512f:
            ii(0x1010_512f, 2); jmp(0x1010_5139, 8); goto l_0x1010_5139; /* jmp 0x10105139 */
        l_0x1010_5131:
            ii(0x1010_5131, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1010_5134, 3); cmp(eax, memd[ss, ebp - 0x14]);         /* cmp eax, [ebp-0x14] */
            ii(0x1010_5137, 2); if(jle(0x1010_513b, 2)) goto l_0x1010_513b; /* jle 0x1010513b */
        l_0x1010_5139:
            ii(0x1010_5139, 2); jmp(0x1010_5141, 6); goto l_0x1010_5141; /* jmp 0x10105141 */
        l_0x1010_513b:
            ii(0x1010_513b, 4); mov(memb[ss, ebp - 0x10], 1);           /* mov byte [ebp-0x10], 0x1 */
            ii(0x1010_513f, 2); jmp(0x1010_5146, 5); goto l_0x1010_5146; /* jmp 0x10105146 */
        l_0x1010_5141:
            ii(0x1010_5141, 5); jmp(0x1010_50c1, -0x85); goto l_0x1010_50c1; /* jmp 0x101050c1 */
        l_0x1010_5146:
            ii(0x1010_5146, 3); mov(al, memb[ss, ebp - 0x10]);          /* mov al, [ebp-0x10] */
            ii(0x1010_5149, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1010_514b, 1); pop(ebp);                               /* pop ebp */
            ii(0x1010_514c, 1); pop(edi);                               /* pop edi */
            ii(0x1010_514d, 1); pop(esi);                               /* pop esi */
            ii(0x1010_514e, 1); pop(ecx);                               /* pop ecx */
            ii(0x1010_514f, 1); ret();                                  /* ret */
        }
    }
}
