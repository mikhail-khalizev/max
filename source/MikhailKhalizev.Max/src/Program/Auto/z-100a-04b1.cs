using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_04b1-94f56e3")]
        public void Method_100a_04b1()
        {
            ii(0x100a_04b1, 5); push(0x3c);                             /* push 0x3c */
            ii(0x100a_04b6, 5); call(Definitions.sys_check_available_stack_size, 0xc_5897); /* call 0x10165d52 */
            ii(0x100a_04bb, 1); push(ebx);                              /* push ebx */
            ii(0x100a_04bc, 1); push(ecx);                              /* push ecx */
            ii(0x100a_04bd, 1); push(edx);                              /* push edx */
            ii(0x100a_04be, 1); push(esi);                              /* push esi */
            ii(0x100a_04bf, 1); push(edi);                              /* push edi */
            ii(0x100a_04c0, 1); push(ebp);                              /* push ebp */
            ii(0x100a_04c1, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_04c3, 6); sub(esp, 0x20);                         /* sub esp, 0x20 */
            ii(0x100a_04c9, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100a_04cc, 5); mov(eax, 0x2);                          /* mov eax, 0x2 */
            ii(0x100a_04d1, 5); call(0x1007_1ec5, -0x2_e611);           /* call 0x10071ec5 */
            ii(0x100a_04d6, 3); mov(memd[ss, ebp - 0x18], eax);         /* mov [ebp-0x18], eax */
            ii(0x100a_04d9, 5); mov(eax, 0x2);                          /* mov eax, 0x2 */
            ii(0x100a_04de, 5); call(0x1007_1f2e, -0x2_e5b5);           /* call 0x10071f2e */
            ii(0x100a_04e3, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x100a_04e6, 3); neg(memd[ss, ebp - 0xc]);               /* neg dword [ebp-0xc] */
            ii(0x100a_04e9, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x100a_04ee, 5); call(0x1007_1ec5, -0x2_e62e);           /* call 0x10071ec5 */
            ii(0x100a_04f3, 3); mov(memd[ss, ebp - 0x14], eax);         /* mov [ebp-0x14], eax */
            ii(0x100a_04f6, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x100a_04fb, 5); call(0x1007_1f2e, -0x2_e5d2);           /* call 0x10071f2e */
            ii(0x100a_0500, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100a_0503, 3); neg(memd[ss, ebp - 0x8]);               /* neg dword [ebp-0x8] */
            ii(0x100a_0506, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_0509, 3); mov(edx, memd[ss, ebp - 0x18]);         /* mov edx, [ebp-0x18] */
            ii(0x100a_050c, 8); imul(dx, memw[ds, eax + 0x373]);        /* imul dx, [eax+0x373] */
            ii(0x100a_0514, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_0517, 3); mov(ebx, memd[ss, ebp - 0x14]);         /* mov ebx, [ebp-0x14] */
            ii(0x100a_051a, 8); imul(bx, memw[ds, eax + 0x371]);        /* imul bx, [eax+0x371] */
            ii(0x100a_0522, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x100a_0524, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x100a_0526, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_0529, 4); add(memw[ds, eax + 0x2e], dx);          /* add [eax+0x2e], dx */
            ii(0x100a_052d, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_0530, 4); mov(dx, memw[ds, eax + 0x24]);          /* mov dx, [eax+0x24] */
            ii(0x100a_0534, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_0537, 4); sub(memw[ds, eax + 0x30], dx);          /* sub [eax+0x30], dx */
            ii(0x100a_053b, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_053e, 4); mov(ax, memw[ds, eax + 0x30]);          /* mov ax, [eax+0x30] */
            ii(0x100a_0542, 3); mov(memd[ss, ebp - 0x1c], eax);         /* mov [ebp-0x1c], eax */
            ii(0x100a_0545, 3); neg(memd[ss, ebp - 0x1c]);              /* neg dword [ebp-0x1c] */
            ii(0x100a_0548, 4); movsx(eax, memw[ss, ebp - 0xc]);        /* movsx eax, word [ebp-0xc] */
            ii(0x100a_054c, 4); movsx(edx, memw[ss, ebp - 0x14]);       /* movsx edx, word [ebp-0x14] */
            ii(0x100a_0550, 3); imul(edx, eax);                         /* imul edx, eax */
            ii(0x100a_0553, 4); movsx(ebx, memw[ss, ebp - 0x18]);       /* movsx ebx, word [ebp-0x18] */
            ii(0x100a_0557, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x100a_0559, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x100a_055c, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x100a_055e, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x100a_0561, 4); movsx(edx, memw[ss, ebp - 0x1c]);       /* movsx edx, word [ebp-0x1c] */
            ii(0x100a_0565, 4); movsx(eax, memw[ss, ebp - 0x8]);        /* movsx eax, word [ebp-0x8] */
            ii(0x100a_0569, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100a_056b, 4); movsx(edx, memw[ss, ebp - 0x10]);       /* movsx edx, word [ebp-0x10] */
            ii(0x100a_056f, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x100a_0571, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100a_0573, 4); movsx(ebx, memw[ss, ebp - 0x8]);        /* movsx ebx, word [ebp-0x8] */
            ii(0x100a_0577, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x100a_0579, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x100a_057c, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x100a_057e, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100a_0580, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_0583, 7); mov(memw[ds, eax + 0x371], dx);         /* mov [eax+0x371], dx */
            ii(0x100a_058a, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_058d, 7); mov(ax, memw[ds, eax + 0x371]);         /* mov ax, [eax+0x371] */
            ii(0x100a_0594, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x100a_0597, 7); cmp(ax, memw[ds, edx + 0x36d]);         /* cmp ax, [edx+0x36d] */
            ii(0x100a_059e, 2); if(jle(0x100a_05b4, 0x14)) goto l_0x100a_05b4; /* jle 0x100a05b4 */
            ii(0x100a_05a0, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_05a3, 7); mov(dx, memw[ds, eax + 0x36d]);         /* mov dx, [eax+0x36d] */
            ii(0x100a_05aa, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_05ad, 7); mov(memw[ds, eax + 0x371], dx);         /* mov [eax+0x371], dx */
        l_0x100a_05b4:
            ii(0x100a_05b4, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_05b7, 7); mov(ax, memw[ds, eax + 0x371]);         /* mov ax, [eax+0x371] */
            ii(0x100a_05be, 4); imul(eax, memd[ss, ebp - 0x8]);         /* imul eax, [ebp-0x8] */
            ii(0x100a_05c2, 3); sub(memd[ss, ebp - 0x1c], eax);         /* sub [ebp-0x1c], eax */
            ii(0x100a_05c5, 4); movsx(eax, memw[ss, ebp - 0x1c]);       /* movsx eax, word [ebp-0x1c] */
            ii(0x100a_05c9, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100a_05cb, 2); if(jge(0x100a_05d4, 0x7)) goto l_0x100a_05d4; /* jge 0x100a05d4 */
            ii(0x100a_05cd, 7); mov(memd[ss, ebp - 0x1c], 0);           /* mov dword [ebp-0x1c], 0x0 */
        l_0x100a_05d4:
            ii(0x100a_05d4, 4); movsx(eax, memw[ss, ebp - 0x1c]);       /* movsx eax, word [ebp-0x1c] */
            ii(0x100a_05d8, 4); movsx(edx, memw[ss, ebp - 0xc]);        /* movsx edx, word [ebp-0xc] */
            ii(0x100a_05dc, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100a_05de, 4); movsx(ebx, memw[ss, ebp - 0xc]);        /* movsx ebx, word [ebp-0xc] */
            ii(0x100a_05e2, 3); lea(edx, eax - 0x1);                    /* lea edx, [eax-0x1] */
            ii(0x100a_05e5, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x100a_05e7, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x100a_05ea, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x100a_05ec, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x100a_05ef, 7); mov(memw[ds, edx + 0x373], ax);         /* mov [edx+0x373], ax */
            ii(0x100a_05f6, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x100a_05f9, 7); mov(ax, memw[ds, edx + 0x373]);         /* mov ax, [edx+0x373] */
            ii(0x100a_0600, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x100a_0603, 7); cmp(ax, memw[ds, edx + 0x36f]);         /* cmp ax, [edx+0x36f] */
            ii(0x100a_060a, 2); if(jle(0x100a_0620, 0x14)) goto l_0x100a_0620; /* jle 0x100a0620 */
            ii(0x100a_060c, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_060f, 7); mov(dx, memw[ds, eax + 0x36f]);         /* mov dx, [eax+0x36f] */
            ii(0x100a_0616, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_0619, 7); mov(memw[ds, eax + 0x373], dx);         /* mov [eax+0x373], dx */
        l_0x100a_0620:
            ii(0x100a_0620, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_0623, 7); mov(ax, memw[ds, eax + 0x373]);         /* mov ax, [eax+0x373] */
            ii(0x100a_062a, 4); imul(eax, memd[ss, ebp - 0xc]);         /* imul eax, [ebp-0xc] */
            ii(0x100a_062e, 3); sub(memd[ss, ebp - 0x1c], eax);         /* sub [ebp-0x1c], eax */
            ii(0x100a_0631, 4); movsx(eax, memw[ss, ebp - 0x1c]);       /* movsx eax, word [ebp-0x1c] */
            ii(0x100a_0635, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100a_0637, 6); if(jle(0x100a_0713, 0xd6)) goto l_0x100a_0713; /* jle 0x100a0713 */
            ii(0x100a_063d, 4); movsx(eax, memw[ss, ebp - 0x1c]);       /* movsx eax, word [ebp-0x1c] */
            ii(0x100a_0641, 4); movsx(edx, memw[ss, ebp - 0x8]);        /* movsx edx, word [ebp-0x8] */
            ii(0x100a_0645, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x100a_0647, 4); movsx(ebx, memw[ss, ebp - 0x8]);        /* movsx ebx, word [ebp-0x8] */
            ii(0x100a_064b, 1); dec(edx);                               /* dec edx */
            ii(0x100a_064c, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x100a_064e, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x100a_0651, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x100a_0653, 3); mov(memd[ss, ebp - 0x20], eax);         /* mov [ebp-0x20], eax */
            ii(0x100a_0656, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x100a_0659, 6); mov(ebx, memd[ds, edx + 0x36b]);        /* mov ebx, [edx+0x36b] */
            ii(0x100a_065f, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x100a_0662, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x100a_0665, 6); mov(eax, memd[ds, edx + 0x36f]);        /* mov eax, [edx+0x36f] */
            ii(0x100a_066b, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100a_066e, 2); sub(ebx, eax);                          /* sub ebx, eax */
            ii(0x100a_0670, 4); movsx(eax, memw[ss, ebp - 0x20]);       /* movsx eax, word [ebp-0x20] */
            ii(0x100a_0674, 2); cmp(eax, ebx);                          /* cmp eax, ebx */
            ii(0x100a_0676, 2); if(jle(0x100a_068f, 0x17)) goto l_0x100a_068f; /* jle 0x100a068f */
            ii(0x100a_0678, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_067b, 7); mov(ax, memw[ds, eax + 0x36d]);         /* mov ax, [eax+0x36d] */
            ii(0x100a_0682, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x100a_0685, 7); sub(ax, memw[ds, edx + 0x371]);         /* sub ax, [edx+0x371] */
            ii(0x100a_068c, 3); mov(memd[ss, ebp - 0x20], eax);         /* mov [ebp-0x20], eax */
        l_0x100a_068f:
            ii(0x100a_068f, 3); mov(eax, memd[ss, ebp - 0x20]);         /* mov eax, [ebp-0x20] */
            ii(0x100a_0692, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x100a_0695, 7); add(memw[ds, edx + 0x371], ax);         /* add [edx+0x371], ax */
            ii(0x100a_069c, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x100a_069f, 7); mov(ax, memw[ds, edx + 0x371]);         /* mov ax, [edx+0x371] */
            ii(0x100a_06a6, 4); imul(eax, memd[ss, ebp - 0x8]);         /* imul eax, [ebp-0x8] */
            ii(0x100a_06aa, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x100a_06ad, 4); mov(dx, memw[ds, edx + 0x30]);          /* mov dx, [edx+0x30] */
            ii(0x100a_06b1, 2); neg(edx);                               /* neg edx */
            ii(0x100a_06b3, 2); sub(edx, eax);                          /* sub edx, eax */
            ii(0x100a_06b5, 3); mov(memd[ss, ebp - 0x1c], edx);         /* mov [ebp-0x1c], edx */
            ii(0x100a_06b8, 4); movsx(edx, memw[ss, ebp - 0x1c]);       /* movsx edx, word [ebp-0x1c] */
            ii(0x100a_06bc, 2); test(edx, edx);                         /* test edx, edx */
            ii(0x100a_06be, 2); if(jge(0x100a_06c7, 0x7)) goto l_0x100a_06c7; /* jge 0x100a06c7 */
            ii(0x100a_06c0, 7); mov(memd[ss, ebp - 0x1c], 0);           /* mov dword [ebp-0x1c], 0x0 */
        l_0x100a_06c7:
            ii(0x100a_06c7, 4); movsx(eax, memw[ss, ebp - 0x1c]);       /* movsx eax, word [ebp-0x1c] */
            ii(0x100a_06cb, 4); movsx(edx, memw[ss, ebp - 0xc]);        /* movsx edx, word [ebp-0xc] */
            ii(0x100a_06cf, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100a_06d1, 4); movsx(ebx, memw[ss, ebp - 0xc]);        /* movsx ebx, word [ebp-0xc] */
            ii(0x100a_06d5, 3); lea(edx, eax - 0x1);                    /* lea edx, [eax-0x1] */
            ii(0x100a_06d8, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x100a_06da, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x100a_06dd, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x100a_06df, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x100a_06e2, 7); mov(memw[ds, edx + 0x373], ax);         /* mov [edx+0x373], ax */
            ii(0x100a_06e9, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x100a_06ec, 7); mov(ax, memw[ds, edx + 0x373]);         /* mov ax, [edx+0x373] */
            ii(0x100a_06f3, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x100a_06f6, 7); cmp(ax, memw[ds, edx + 0x36f]);         /* cmp ax, [edx+0x36f] */
            ii(0x100a_06fd, 2); if(jle(0x100a_0713, 0x14)) goto l_0x100a_0713; /* jle 0x100a0713 */
            ii(0x100a_06ff, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_0702, 7); mov(dx, memw[ds, eax + 0x36f]);         /* mov dx, [eax+0x36f] */
            ii(0x100a_0709, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_070c, 7); mov(memw[ds, eax + 0x373], dx);         /* mov [eax+0x373], dx */
        l_0x100a_0713:
            ii(0x100a_0713, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_0716, 7); mov(bx, memw[ds, eax + 0x371]);         /* mov bx, [eax+0x371] */
            ii(0x100a_071d, 4); imul(ebx, memd[ss, ebp - 0x8]);         /* imul ebx, [ebp-0x8] */
            ii(0x100a_0721, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_0724, 7); mov(dx, memw[ds, eax + 0x373]);         /* mov dx, [eax+0x373] */
            ii(0x100a_072b, 4); imul(edx, memd[ss, ebp - 0xc]);         /* imul edx, [ebp-0xc] */
            ii(0x100a_072f, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_0732, 2); add(ebx, edx);                          /* add ebx, edx */
            ii(0x100a_0734, 4); mov(memw[ds, eax + 0x24], bx);          /* mov [eax+0x24], bx */
            ii(0x100a_0738, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_073b, 4); mov(dx, memw[ds, eax + 0x24]);          /* mov dx, [eax+0x24] */
            ii(0x100a_073f, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_0742, 4); add(memw[ds, eax + 0x30], dx);          /* add [eax+0x30], dx */
            ii(0x100a_0746, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_0749, 7); mov(dx, memw[ds, eax + 0x371]);         /* mov dx, [eax+0x371] */
            ii(0x100a_0750, 4); imul(edx, memd[ss, ebp - 0x14]);        /* imul edx, [ebp-0x14] */
            ii(0x100a_0754, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_0757, 7); mov(ax, memw[ds, eax + 0x373]);         /* mov ax, [eax+0x373] */
            ii(0x100a_075e, 4); imul(eax, memd[ss, ebp - 0x18]);        /* imul eax, [ebp-0x18] */
            ii(0x100a_0762, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x100a_0764, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_0767, 4); sub(memw[ds, eax + 0x2e], dx);          /* sub [eax+0x2e], dx */
            ii(0x100a_076b, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_076d, 1); pop(ebp);                               /* pop ebp */
            ii(0x100a_076e, 1); pop(edi);                               /* pop edi */
            ii(0x100a_076f, 1); pop(esi);                               /* pop esi */
            ii(0x100a_0770, 1); pop(edx);                               /* pop edx */
            ii(0x100a_0771, 1); pop(ecx);                               /* pop ecx */
            ii(0x100a_0772, 1); pop(ebx);                               /* pop ebx */
            ii(0x100a_0773, 1); ret();                                  /* ret */
        }
    }
}
