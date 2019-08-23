using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100f_066e-d3041e3c")]
        public void Method_100f_066e()
        {
            ii(0x100f_066e, 5); push(0x24);                             /* push 0x24 */
            ii(0x100f_0673, 5); call(Definitions.sys_check_available_stack_size, 0x7_56da); /* call 0x10165d52 */
            ii(0x100f_0678, 1); push(ebx);                              /* push ebx */
            ii(0x100f_0679, 1); push(ecx);                              /* push ecx */
            ii(0x100f_067a, 1); push(edx);                              /* push edx */
            ii(0x100f_067b, 1); push(esi);                              /* push esi */
            ii(0x100f_067c, 1); push(edi);                              /* push edi */
            ii(0x100f_067d, 1); push(ebp);                              /* push ebp */
            ii(0x100f_067e, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100f_0680, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100f_0686, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100f_0689, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100f_068c, 4); inc(memw[ds, eax + 0x67]);              /* inc word [eax+0x67] */
            ii(0x100f_0690, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100f_0693, 4); mov(dx, memw[ds, eax + 0x67]);          /* mov dx, [eax+0x67] */
            ii(0x100f_0697, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100f_069a, 4); cmp(dx, memw[ds, eax + 0x61]);          /* cmp dx, [eax+0x61] */
            ii(0x100f_069e, 2); if(jle(0x100f_06eb, 0x4b)) goto l_0x100f_06eb; /* jle 0x100f06eb */
            ii(0x100f_06a0, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100f_06a3, 4); cmp(memb[ds, eax + 0x60], 0x2);         /* cmp byte [eax+0x60], 0x2 */
            ii(0x100f_06a7, 2); if(jz(0x100f_06ba, 0x11)) goto l_0x100f_06ba; /* jz 0x100f06ba */
            ii(0x100f_06a9, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100f_06ac, 5); call(0x100f_0748, 0x97);                /* call 0x100f0748 */
            ii(0x100f_06b1, 4); mov(memb[ss, ebp - 0x8], 0);            /* mov byte [ebp-0x8], 0x0 */
            ii(0x100f_06b5, 5); jmp(0x100f_073c, 0x82); goto l_0x100f_073c; /* jmp 0x100f073c */
        l_0x100f_06ba:
            ii(0x100f_06ba, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100f_06bd, 6); mov(memw[ds, eax + 0x67], 0x1);         /* mov word [eax+0x67], 0x1 */
            ii(0x100f_06c3, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100f_06c6, 3); mov(eax, memd[ds, eax + 0x2]);          /* mov eax, [eax+0x2] */
            ii(0x100f_06c9, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100f_06cc, 3); cmp(eax, 0x1);                          /* cmp eax, 0x1 */
            ii(0x100f_06cf, 2); if(jz(0x100f_06eb, 0x1a)) goto l_0x100f_06eb; /* jz 0x100f06eb */
            ii(0x100f_06d1, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100f_06d3, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100f_06d6, 3); mov(edx, memd[ds, eax + 0x44]);         /* mov edx, [eax+0x44] */
            ii(0x100f_06d9, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100f_06dc, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x100f_06de, 5); call(Definitions.my_fseek, -0x128e);    /* call 0x100ef455 */
            ii(0x100f_06e3, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100f_06e6, 5); call(0x100f_01bb, -0x530);              /* call 0x100f01bb */
        l_0x100f_06eb:
            ii(0x100f_06eb, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100f_06ee, 3); mov(edx, memd[ds, eax + 0x2]);          /* mov edx, [eax+0x2] */
            ii(0x100f_06f1, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100f_06f4, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100f_06f7, 3); mov(eax, memd[ds, eax + 0x65]);         /* mov eax, [eax+0x65] */
            ii(0x100f_06fa, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100f_06fd, 3); add(edx, 0x5);                          /* add edx, 0x5 */
            ii(0x100f_0700, 2); cmp(eax, edx);                          /* cmp eax, edx */
            ii(0x100f_0702, 2); if(jb(0x100f_070c, 0x8)) goto l_0x100f_070c; /* jb 0x100f070c */
            ii(0x100f_0704, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100f_0707, 5); call(0x100f_01bb, -0x551);              /* call 0x100f01bb */
        l_0x100f_070c:
            ii(0x100f_070c, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x100f_070f, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100f_0712, 3); mov(eax, memd[ds, eax + 0x65]);         /* mov eax, [eax+0x65] */
            ii(0x100f_0715, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100f_0718, 3); imul(eax, eax, 0xc);                    /* imul eax, eax, 0xc */
            ii(0x100f_071b, 3); mov(ebx, memd[ss, ebp - 0x4]);          /* mov ebx, [ebp-0x4] */
            ii(0x100f_071e, 3); add(ebx, 0x8);                          /* add ebx, 0x8 */
            ii(0x100f_0721, 2); add(ebx, eax);                          /* add ebx, eax */
            ii(0x100f_0723, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100f_0726, 3); mov(eax, memd[ds, eax + 0x2]);          /* mov eax, [eax+0x2] */
            ii(0x100f_0729, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100f_072c, 3); imul(eax, eax, 0xc);                    /* imul eax, eax, 0xc */
            ii(0x100f_072f, 2); sub(ebx, eax);                          /* sub ebx, eax */
            ii(0x100f_0731, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x100f_0733, 5); call(0x100e_fed0, -0x868);              /* call 0x100efed0 */
            ii(0x100f_0738, 4); mov(memb[ss, ebp - 0x8], 0x1);          /* mov byte [ebp-0x8], 0x1 */
        l_0x100f_073c:
            ii(0x100f_073c, 3); mov(al, memb[ss, ebp - 0x8]);           /* mov al, [ebp-0x8] */
            ii(0x100f_073f, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100f_0741, 1); pop(ebp);                               /* pop ebp */
            ii(0x100f_0742, 1); pop(edi);                               /* pop edi */
            ii(0x100f_0743, 1); pop(esi);                               /* pop esi */
            ii(0x100f_0744, 1); pop(edx);                               /* pop edx */
            ii(0x100f_0745, 1); pop(ecx);                               /* pop ecx */
            ii(0x100f_0746, 1); pop(ebx);                               /* pop ebx */
            ii(0x100f_0747, 1); ret();                                  /* ret */
        }
    }
}
