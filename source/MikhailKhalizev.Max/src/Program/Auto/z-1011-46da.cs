using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1011_46da-470e08a5")]
        public void Method_1011_46da()
        {
            ii(0x1011_46da, 5); push(0x24);                             /* push 0x24 */
            ii(0x1011_46df, 5); call(Definitions.sys_check_available_stack_size, 0x5_166e); /* call 0x10165d52 */
            ii(0x1011_46e4, 1); push(ebx);                              /* push ebx */
            ii(0x1011_46e5, 1); push(ecx);                              /* push ecx */
            ii(0x1011_46e6, 1); push(esi);                              /* push esi */
            ii(0x1011_46e7, 1); push(edi);                              /* push edi */
            ii(0x1011_46e8, 1); push(ebp);                              /* push ebp */
            ii(0x1011_46e9, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1011_46eb, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1011_46f1, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1011_46f4, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x1011_46f7, 4); mov(memb[ss, ebp - 0xc], 4);            /* mov byte [ebp-0xc], 0x4 */
            ii(0x1011_46fb, 4); cmp(memd[ss, ebp - 4], 0);              /* cmp dword [ebp-0x4], 0x0 */
            ii(0x1011_46ff, 2); if(jz(0x1011_4765, 0x64)) goto l_0x1011_4765; /* jz 0x10114765 */
            ii(0x1011_4701, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1011_4704, 7); mov(memb[ds, eax + 0x51f], 1);          /* mov byte [eax+0x51f], 0x1 */
        l_0x1011_470b:
            ii(0x1011_470b, 3); dec(memb[ss, ebp - 0xc]);               /* dec byte [ebp-0xc] */
            ii(0x1011_470e, 4); cmp(memb[ss, ebp - 0xc], -1 /* 0xff */); /* cmp byte [ebp-0xc], 0xff */
            ii(0x1011_4712, 2); if(jz(0x1011_473e, 0x2a)) goto l_0x1011_473e; /* jz 0x1011473e */
            ii(0x1011_4714, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1011_4716, 3); mov(dl, memb[ss, ebp - 0xc]);           /* mov dl, [ebp-0xc] */
            ii(0x1011_4719, 3); imul(edx, edx, 0x1e);                   /* imul edx, edx, 0x1e */
            ii(0x1011_471c, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1011_471f, 3); add(eax, 0x24);                         /* add eax, 0x24 */
            ii(0x1011_4722, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1011_4724, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1011_4726, 3); mov(al, memb[ss, ebp - 0xc]);           /* mov al, [ebp-0xc] */
            ii(0x1011_4729, 3); imul(eax, eax, 0x1e);                   /* imul eax, eax, 0x1e */
            ii(0x1011_472c, 3); mov(ebx, memd[ss, ebp - 8]);            /* mov ebx, [ebp-0x8] */
            ii(0x1011_472f, 6); add(ebx, 0x520);                        /* add ebx, 0x520 */
            ii(0x1011_4735, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x1011_4737, 5); call(Definitions.sys_strcpy, 0x5_1793); /* call 0x10165ecf */
            ii(0x1011_473c, 2); jmp(0x1011_470b, -0x33); goto l_0x1011_470b; /* jmp 0x1011470b */
        l_0x1011_473e:
            ii(0x1011_473e, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1011_4741, 6); mov(edx, memd[ds, eax + 0xa6]);         /* mov edx, [eax+0xa6] */
            ii(0x1011_4747, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1011_474a, 6); mov(memd[ds, eax + 0x599], edx);        /* mov [eax+0x599], edx */
            ii(0x1011_4750, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1011_4753, 3); add(edx, 3);                            /* add edx, 0x3 */
            ii(0x1011_4756, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1011_4759, 5); add(eax, 0x4f0);                        /* add eax, 0x4f0 */
            ii(0x1011_475e, 5); call(Definitions.sys_strcpy, 0x5_176c); /* call 0x10165ecf */
            ii(0x1011_4763, 2); jmp(0x1011_478c, 0x27); goto l_0x1011_478c; /* jmp 0x1011478c */
        l_0x1011_4765:
            ii(0x1011_4765, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1011_4768, 7); mov(memb[ds, eax + 0x51f], 0);          /* mov byte [eax+0x51f], 0x0 */
        l_0x1011_476f:
            ii(0x1011_476f, 3); dec(memb[ss, ebp - 0xc]);               /* dec byte [ebp-0xc] */
            ii(0x1011_4772, 4); cmp(memb[ss, ebp - 0xc], -1 /* 0xff */); /* cmp byte [ebp-0xc], 0xff */
            ii(0x1011_4776, 2); if(jz(0x1011_478c, 0x14)) goto l_0x1011_478c; /* jz 0x1011478c */
            ii(0x1011_4778, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1011_477a, 3); mov(al, memb[ss, ebp - 0xc]);           /* mov al, [ebp-0xc] */
            ii(0x1011_477d, 3); imul(eax, eax, 0x1e);                   /* imul eax, eax, 0x1e */
            ii(0x1011_4780, 3); add(eax, memd[ss, ebp - 8]);            /* add eax, [ebp-0x8] */
            ii(0x1011_4783, 7); mov(memb[ds, eax + 0x520], 0);          /* mov byte [eax+0x520], 0x0 */
            ii(0x1011_478a, 2); jmp(0x1011_476f, -0x1d); goto l_0x1011_476f; /* jmp 0x1011476f */
        l_0x1011_478c:
            ii(0x1011_478c, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1011_478f, 7); mov(memb[ds, eax + 0x51e], 1);          /* mov byte [eax+0x51e], 0x1 */
            ii(0x1011_4796, 5); call(0x1012_abdb, 0x1_6440);            /* call 0x1012abdb */
            ii(0x1011_479b, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1011_479d, 1); pop(ebp);                               /* pop ebp */
            ii(0x1011_479e, 1); pop(edi);                               /* pop edi */
            ii(0x1011_479f, 1); pop(esi);                               /* pop esi */
            ii(0x1011_47a0, 1); pop(ecx);                               /* pop ecx */
            ii(0x1011_47a1, 1); pop(ebx);                               /* pop ebx */
            ii(0x1011_47a2, 1); ret();                                  /* ret */
        }
    }
}
