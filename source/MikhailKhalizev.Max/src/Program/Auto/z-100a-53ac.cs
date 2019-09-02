using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_53ac-60e7f0ec")]
        public void Method_100a_53ac()
        {
            ii(0x100a_53ac, 5); push(0x34);                             /* push 0x34 */
            ii(0x100a_53b1, 5); call(Definitions.sys_check_available_stack_size, 0xc_099c); /* call 0x10165d52 */
            ii(0x100a_53b6, 1); push(ecx);                              /* push ecx */
            ii(0x100a_53b7, 1); push(esi);                              /* push esi */
            ii(0x100a_53b8, 1); push(edi);                              /* push edi */
            ii(0x100a_53b9, 1); push(ebp);                              /* push ebp */
            ii(0x100a_53ba, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_53bc, 6); sub(esp, 0x20);                         /* sub esp, 0x20 */
            ii(0x100a_53c2, 3); mov(memd[ss, ebp - 12], eax);           /* mov [ebp-0xc], eax */
            ii(0x100a_53c5, 3); mov(memd[ss, ebp - 8], edx);            /* mov [ebp-0x8], edx */
            ii(0x100a_53c8, 3); mov(memb[ss, ebp - 4], bl);             /* mov [ebp-0x4], bl */
            ii(0x100a_53cb, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100a_53ce, 5); call(0x1015_287d, 0xa_d4aa);            /* call 0x1015287d */
            ii(0x100a_53d3, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100a_53d5, 5); mov(edx, 0x100);                        /* mov edx, 0x100 */
            ii(0x100a_53da, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100a_53dd, 5); call(0x100a_b120, 0x5d3e);              /* call 0x100ab120 */
            ii(0x100a_53e2, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100a_53e5, 3); mov(al, memb[ds, eax + 77]);            /* mov al, [eax+0x4d] */
            ii(0x100a_53e8, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100a_53ed, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100a_53ef, 2); if(jle(0x100a_5412, 0x21)) goto l_0x100a_5412; /* jle 0x100a5412 */
            ii(0x100a_53f1, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100a_53f4, 3); mov(al, memb[ds, eax + 38]);            /* mov al, [eax+0x26] */
            ii(0x100a_53f7, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100a_53fc, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x100a_5402, 6); mov(al, memb[ds, eax + 0x101c_a490]);   /* mov al, [eax+0x101ca490] */
            ii(0x100a_5408, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100a_540d, 3); cmp(eax, 2);                            /* cmp eax, 0x2 */
            ii(0x100a_5410, 2); if(jz(0x100a_5414, 2)) goto l_0x100a_5414; /* jz 0x100a5414 */
        l_0x100a_5412:
            ii(0x100a_5412, 2); jmp(0x100a_545f, 0x4b); goto l_0x100a_545f; /* jmp 0x100a545f */
        l_0x100a_5414:
            ii(0x100a_5414, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100a_5416, 3); mov(al, memb[ss, ebp - 4]);             /* mov al, [ebp-0x4] */
            ii(0x100a_5419, 3); mov(memd[ss, ebp - 16], eax);           /* mov [ebp-0x10], eax */
            ii(0x100a_541c, 5); mov(eax, 0xa);                          /* mov eax, 0xa */
            ii(0x100a_5421, 5); call(Definitions.sys_new, 0xc_09da);    /* call 0x10165e00 */
            ii(0x100a_5426, 3); mov(memd[ss, ebp - 20], eax);           /* mov [ebp-0x14], eax */
            ii(0x100a_5429, 3); mov(eax, memd[ss, ebp - 20]);           /* mov eax, [ebp-0x14] */
            ii(0x100a_542c, 3); mov(memd[ss, ebp - 24], eax);           /* mov [ebp-0x18], eax */
            ii(0x100a_542f, 4); cmp(memd[ss, ebp - 24], 0);             /* cmp dword [ebp-0x18], 0x0 */
            ii(0x100a_5433, 2); if(jz(0x100a_544b, 0x16)) goto l_0x100a_544b; /* jz 0x100a544b */
            ii(0x100a_5435, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x100a_5438, 3); mov(eax, memd[ss, ebp - 20]);           /* mov eax, [ebp-0x14] */
            ii(0x100a_543b, 5); call(0x100a_3a81, -0x19bf);             /* call 0x100a3a81 */
            ii(0x100a_5440, 3); mov(memd[ss, ebp - 28], eax);           /* mov [ebp-0x1c], eax */
            ii(0x100a_5443, 3); mov(eax, memd[ss, ebp - 28]);           /* mov eax, [ebp-0x1c] */
            ii(0x100a_5446, 3); mov(memd[ss, ebp - 32], eax);           /* mov [ebp-0x20], eax */
            ii(0x100a_5449, 2); jmp(0x100a_5451, 6); goto l_0x100a_5451; /* jmp 0x100a5451 */
        l_0x100a_544b:
            ii(0x100a_544b, 3); mov(eax, memd[ss, ebp - 24]);           /* mov eax, [ebp-0x18] */
            ii(0x100a_544e, 3); mov(memd[ss, ebp - 32], eax);           /* mov [ebp-0x20], eax */
        l_0x100a_5451:
            ii(0x100a_5451, 3); mov(edx, memd[ss, ebp - 32]);           /* mov edx, [ebp-0x20] */
            ii(0x100a_5454, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x100a_5457, 3); mov(ebx, memd[ss, ebp - 16]);           /* mov ebx, [ebp-0x10] */
            ii(0x100a_545a, 5); call(0x100a_4db6, -0x6a9);              /* call 0x100a4db6 */
        l_0x100a_545f:
            ii(0x100a_545f, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_5461, 1); pop(ebp);                               /* pop ebp */
            ii(0x100a_5462, 1); pop(edi);                               /* pop edi */
            ii(0x100a_5463, 1); pop(esi);                               /* pop esi */
            ii(0x100a_5464, 1); pop(ecx);                               /* pop ecx */
            ii(0x100a_5465, 1); ret();                                  /* ret */
        }
    }
}
