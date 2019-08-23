using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_5537-1eaf7532")]
        public void Method_1007_5537()
        {
            ii(0x1007_5537, 5); push(0x48);                             /* push 0x48 */
            ii(0x1007_553c, 5); call(Definitions.sys_check_available_stack_size, 0xf_0811); /* call 0x10165d52 */
            ii(0x1007_5541, 1); push(ebx);                              /* push ebx */
            ii(0x1007_5542, 1); push(ecx);                              /* push ecx */
            ii(0x1007_5543, 1); push(esi);                              /* push esi */
            ii(0x1007_5544, 1); push(edi);                              /* push edi */
            ii(0x1007_5545, 1); push(ebp);                              /* push ebp */
            ii(0x1007_5546, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1007_5548, 6); sub(esp, 0x30);                         /* sub esp, 0x30 */
            ii(0x1007_554e, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1007_5551, 3); mov(memd[ss, ebp - 0x4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1007_5554, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_5557, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x1007_5559, 3); add(eax, 0x10);                         /* add eax, 0x10 */
            ii(0x1007_555c, 3); sar(eax, 0x6);                          /* sar eax, 0x6 */
            ii(0x1007_555f, 3); mov(memd[ss, ebp - 0x1c], eax);         /* mov [ebp-0x1c], eax */
            ii(0x1007_5562, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_5565, 3); mov(eax, memd[ds, eax + 0x4]);          /* mov eax, [eax+0x4] */
            ii(0x1007_5568, 3); add(eax, 0x10);                         /* add eax, 0x10 */
            ii(0x1007_556b, 3); sar(eax, 0x6);                          /* sar eax, 0x6 */
            ii(0x1007_556e, 3); mov(memd[ss, ebp - 0x20], eax);         /* mov [ebp-0x20], eax */
            ii(0x1007_5571, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_5574, 3); mov(eax, memd[ds, eax + 0x8]);          /* mov eax, [eax+0x8] */
            ii(0x1007_5577, 3); sub(eax, 0x10);                         /* sub eax, 0x10 */
            ii(0x1007_557a, 3); sar(eax, 0x6);                          /* sar eax, 0x6 */
            ii(0x1007_557d, 3); mov(memd[ss, ebp - 0x14], eax);         /* mov [ebp-0x14], eax */
            ii(0x1007_5580, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_5583, 3); mov(eax, memd[ds, eax + 0xc]);          /* mov eax, [eax+0xc] */
            ii(0x1007_5586, 3); sub(eax, 0x10);                         /* sub eax, 0x10 */
            ii(0x1007_5589, 3); sar(eax, 0x6);                          /* sar eax, 0x6 */
            ii(0x1007_558c, 3); mov(memd[ss, ebp - 0x18], eax);         /* mov [ebp-0x18], eax */
            ii(0x1007_558f, 7); mov(memd[ss, ebp - 0x24], 0);           /* mov dword [ebp-0x24], 0x0 */
            ii(0x1007_5596, 4); cmp(memd[ss, ebp - 0x8], 0);            /* cmp dword [ebp-0x8], 0x0 */
            ii(0x1007_559a, 6); if(jz(0x1007_561d, 0x7d)) goto l_0x1007_561d; /* jz 0x1007561d */
            ii(0x1007_55a0, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1007_55a3, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_55a5, 3); mov(dl, memb[ds, eax + 0x26]);          /* mov dl, [eax+0x26] */
            ii(0x1007_55a8, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1007_55aa, 5); mov(al, memb[ds, 0x101c_37da]);         /* mov al, [0x101c37da] */
            ii(0x1007_55af, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1007_55b1, 2); if(jnz(0x1007_55be, 0xb)) goto l_0x1007_55be; /* jnz 0x100755be */
            ii(0x1007_55b3, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1007_55b6, 6); test(memw[ds, eax + 0x12], 0x1c0);      /* test word [eax+0x12], 0x1c0 */
            ii(0x1007_55bc, 2); if(jnz(0x1007_55c0, 0x2)) goto l_0x1007_55c0; /* jnz 0x100755c0 */
        l_0x1007_55be:
            ii(0x1007_55be, 2); jmp(0x1007_55c9, 0x9); goto l_0x1007_55c9; /* jmp 0x100755c9 */
        l_0x1007_55c0:
            ii(0x1007_55c0, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1007_55c3, 4); cmp(memb[ds, eax + 0x3e], 0x1);         /* cmp byte [eax+0x3e], 0x1 */
            ii(0x1007_55c7, 2); if(jz(0x1007_55cb, 0x2)) goto l_0x1007_55cb; /* jz 0x100755cb */
        l_0x1007_55c9:
            ii(0x1007_55c9, 2); jmp(0x1007_55d8, 0xd); goto l_0x1007_55d8; /* jmp 0x100755d8 */
        l_0x1007_55cb:
            ii(0x1007_55cb, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1007_55ce, 4); mov(ax, memw[ds, eax + 0x1a]);          /* mov ax, [eax+0x1a] */
            ii(0x1007_55d2, 4); cmp(ax, memw[ss, ebp - 0x1c]);          /* cmp ax, [ebp-0x1c] */
            ii(0x1007_55d6, 2); if(jge(0x1007_55da, 0x2)) goto l_0x1007_55da; /* jge 0x100755da */
        l_0x1007_55d8:
            ii(0x1007_55d8, 2); jmp(0x1007_55e7, 0xd); goto l_0x1007_55e7; /* jmp 0x100755e7 */
        l_0x1007_55da:
            ii(0x1007_55da, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1007_55dd, 4); mov(ax, memw[ds, eax + 0x1a]);          /* mov ax, [eax+0x1a] */
            ii(0x1007_55e1, 4); cmp(ax, memw[ss, ebp - 0x14]);          /* cmp ax, [ebp-0x14] */
            ii(0x1007_55e5, 2); if(jle(0x1007_55e9, 0x2)) goto l_0x1007_55e9; /* jle 0x100755e9 */
        l_0x1007_55e7:
            ii(0x1007_55e7, 2); jmp(0x1007_55f6, 0xd); goto l_0x1007_55f6; /* jmp 0x100755f6 */
        l_0x1007_55e9:
            ii(0x1007_55e9, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1007_55ec, 4); mov(ax, memw[ds, eax + 0x1c]);          /* mov ax, [eax+0x1c] */
            ii(0x1007_55f0, 4); cmp(ax, memw[ss, ebp - 0x20]);          /* cmp ax, [ebp-0x20] */
            ii(0x1007_55f4, 2); if(jge(0x1007_55f8, 0x2)) goto l_0x1007_55f8; /* jge 0x100755f8 */
        l_0x1007_55f6:
            ii(0x1007_55f6, 2); jmp(0x1007_5605, 0xd); goto l_0x1007_5605; /* jmp 0x10075605 */
        l_0x1007_55f8:
            ii(0x1007_55f8, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1007_55fb, 4); mov(ax, memw[ds, eax + 0x1c]);          /* mov ax, [eax+0x1c] */
            ii(0x1007_55ff, 4); cmp(ax, memw[ss, ebp - 0x18]);          /* cmp ax, [ebp-0x18] */
            ii(0x1007_5603, 2); if(jle(0x1007_5607, 0x2)) goto l_0x1007_5607; /* jle 0x10075607 */
        l_0x1007_5605:
            ii(0x1007_5605, 2); jmp(0x1007_561d, 0x16); goto l_0x1007_561d; /* jmp 0x1007561d */
        l_0x1007_5607:
            ii(0x1007_5607, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1007_560a, 3); mov(memd[ss, ebp - 0x24], eax);         /* mov [ebp-0x24], eax */
            ii(0x1007_560d, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1007_5610, 5); call(0x1014_b6bd, 0xd_60a8);            /* call 0x1014b6bd */
            ii(0x1007_5615, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1007_5618, 5); call(0x1014_b5ef, 0xd_5fd2);            /* call 0x1014b5ef */
        l_0x1007_561d:
            ii(0x1007_561d, 4); cmp(memd[ss, ebp - 0x24], 0);           /* cmp dword [ebp-0x24], 0x0 */
            ii(0x1007_5621, 2); if(jnz(0x1007_562c, 0x9)) goto l_0x1007_562c; /* jnz 0x1007562c */
            ii(0x1007_5623, 7); mov(memd[ss, ebp - 0x28], 0);           /* mov dword [ebp-0x28], 0x0 */
            ii(0x1007_562a, 2); jmp(0x1007_5633, 0x7); goto l_0x1007_5633; /* jmp 0x10075633 */
        l_0x1007_562c:
            ii(0x1007_562c, 7); mov(memd[ss, ebp - 0x28], 0x1);         /* mov dword [ebp-0x28], 0x1 */
        l_0x1007_5633:
            ii(0x1007_5633, 3); mov(eax, memd[ss, ebp - 0x28]);         /* mov eax, [ebp-0x28] */
            ii(0x1007_5636, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x1007_5639, 4); mov(memb[ss, ebp - 0xc], 0);            /* mov byte [ebp-0xc], 0x0 */
        l_0x1007_563d:
            ii(0x1007_563d, 3); mov(eax, memd[ss, ebp - 0x20]);         /* mov eax, [ebp-0x20] */
            ii(0x1007_5640, 4); cmp(ax, memw[ss, ebp - 0x18]);          /* cmp ax, [ebp-0x18] */
            ii(0x1007_5644, 2); if(jg(0x1007_564f, 0x9)) goto l_0x1007_564f; /* jg 0x1007564f */
            ii(0x1007_5646, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1007_5648, 3); mov(al, memb[ss, ebp - 0xc]);           /* mov al, [ebp-0xc] */
            ii(0x1007_564b, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1007_564d, 2); if(jz(0x1007_5654, 0x5)) goto l_0x1007_5654; /* jz 0x10075654 */
        l_0x1007_564f:
            ii(0x1007_564f, 5); jmp(0x1007_570a, 0xb6); goto l_0x1007_570a; /* jmp 0x1007570a */
        l_0x1007_5654:
            ii(0x1007_5654, 3); mov(eax, memd[ss, ebp - 0x1c]);         /* mov eax, [ebp-0x1c] */
            ii(0x1007_5657, 3); mov(memd[ss, ebp - 0x2c], eax);         /* mov [ebp-0x2c], eax */
        l_0x1007_565a:
            ii(0x1007_565a, 3); mov(eax, memd[ss, ebp - 0x2c]);         /* mov eax, [ebp-0x2c] */
            ii(0x1007_565d, 4); cmp(ax, memw[ss, ebp - 0x14]);          /* cmp ax, [ebp-0x14] */
            ii(0x1007_5661, 2); if(jg(0x1007_566c, 0x9)) goto l_0x1007_566c; /* jg 0x1007566c */
            ii(0x1007_5663, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1007_5665, 3); mov(al, memb[ss, ebp - 0xc]);           /* mov al, [ebp-0xc] */
            ii(0x1007_5668, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1007_566a, 2); if(jz(0x1007_5671, 0x5)) goto l_0x1007_5671; /* jz 0x10075671 */
        l_0x1007_566c:
            ii(0x1007_566c, 5); jmp(0x1007_56ff, 0x8e); goto l_0x1007_56ff; /* jmp 0x100756ff */
        l_0x1007_5671:
            ii(0x1007_5671, 5); mov(ecx, 0x1c0);                        /* mov ecx, 0x1c0 */
            ii(0x1007_5676, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1007_5678, 5); mov(al, memb[ds, 0x101c_37da]);         /* mov al, [0x101c37da] */
            ii(0x1007_567d, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x1007_5680, 4); movsx(edx, memw[ss, ebp - 0x20]);       /* movsx edx, word [ebp-0x20] */
            ii(0x1007_5684, 4); movsx(eax, memw[ss, ebp - 0x2c]);       /* movsx eax, word [ebp-0x2c] */
            ii(0x1007_5688, 5); call(0x1007_388b, -0x1e02);             /* call 0x1007388b */
            ii(0x1007_568d, 3); mov(memd[ss, ebp - 0x30], eax);         /* mov [ebp-0x30], eax */
            ii(0x1007_5690, 4); cmp(memd[ss, ebp - 0x30], 0);           /* cmp dword [ebp-0x30], 0x0 */
            ii(0x1007_5694, 2); if(jz(0x1007_56aa, 0x14)) goto l_0x1007_56aa; /* jz 0x100756aa */
            ii(0x1007_5696, 3); mov(eax, memd[ss, ebp - 0x30]);         /* mov eax, [ebp-0x30] */
            ii(0x1007_5699, 4); cmp(memb[ds, eax + 0x3e], 0x1);         /* cmp byte [eax+0x3e], 0x1 */
            ii(0x1007_569d, 2); if(jz(0x1007_56a8, 0x9)) goto l_0x1007_56a8; /* jz 0x100756a8 */
            ii(0x1007_569f, 3); mov(eax, memd[ss, ebp - 0x30]);         /* mov eax, [ebp-0x30] */
            ii(0x1007_56a2, 4); cmp(memb[ds, eax + 0x3e], 0x2);         /* cmp byte [eax+0x3e], 0x2 */
            ii(0x1007_56a6, 2); if(jnz(0x1007_56aa, 0x2)) goto l_0x1007_56aa; /* jnz 0x100756aa */
        l_0x1007_56a8:
            ii(0x1007_56a8, 2); jmp(0x1007_56ac, 0x2); goto l_0x1007_56ac; /* jmp 0x100756ac */
        l_0x1007_56aa:
            ii(0x1007_56aa, 2); jmp(0x1007_56f4, 0x48); goto l_0x1007_56f4; /* jmp 0x100756f4 */
        l_0x1007_56ac:
            ii(0x1007_56ac, 3); mov(eax, memd[ss, ebp - 0x30]);         /* mov eax, [ebp-0x30] */
            ii(0x1007_56af, 5); call(0x1014_b6bd, 0xd_6009);            /* call 0x1014b6bd */
            ii(0x1007_56b4, 4); cmp(memd[ss, ebp - 0x24], 0);           /* cmp dword [ebp-0x24], 0x0 */
            ii(0x1007_56b8, 2); if(jnz(0x1007_56ce, 0x14)) goto l_0x1007_56ce; /* jnz 0x100756ce */
            ii(0x1007_56ba, 3); mov(eax, memd[ss, ebp - 0x30]);         /* mov eax, [ebp-0x30] */
            ii(0x1007_56bd, 5); call(0x1014_b5ef, 0xd_5f2d);            /* call 0x1014b5ef */
            ii(0x1007_56c2, 3); mov(eax, memd[ss, ebp - 0x30]);         /* mov eax, [ebp-0x30] */
            ii(0x1007_56c5, 3); mov(memd[ss, ebp - 0x24], eax);         /* mov [ebp-0x24], eax */
            ii(0x1007_56c8, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1007_56cb, 3); inc(memd[ss, ebp - 0x10]);              /* inc dword [ebp-0x10] */
        l_0x1007_56ce:
            ii(0x1007_56ce, 3); mov(edx, memd[ss, ebp - 0x24]);         /* mov edx, [ebp-0x24] */
            ii(0x1007_56d1, 3); mov(eax, memd[ss, ebp - 0x30]);         /* mov eax, [ebp-0x30] */
            ii(0x1007_56d4, 5); call(0x1014_b64e, 0xd_5f75);            /* call 0x1014b64e */
            ii(0x1007_56d9, 3); mov(eax, memd[ss, ebp - 0x24]);         /* mov eax, [ebp-0x24] */
            ii(0x1007_56dc, 3); cmp(eax, memd[ss, ebp - 0x30]);         /* cmp eax, [ebp-0x30] */
            ii(0x1007_56df, 2); if(jz(0x1007_56e7, 0x6)) goto l_0x1007_56e7; /* jz 0x100756e7 */
            ii(0x1007_56e1, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1007_56e4, 3); inc(memd[ss, ebp - 0x10]);              /* inc dword [ebp-0x10] */
        l_0x1007_56e7:
            ii(0x1007_56e7, 4); movsx(eax, memw[ss, ebp - 0x10]);       /* movsx eax, word [ebp-0x10] */
            ii(0x1007_56eb, 3); cmp(eax, 0xa);                          /* cmp eax, 0xa */
            ii(0x1007_56ee, 2); if(jnz(0x1007_56f4, 0x4)) goto l_0x1007_56f4; /* jnz 0x100756f4 */
            ii(0x1007_56f0, 4); mov(memb[ss, ebp - 0xc], 0x1);          /* mov byte [ebp-0xc], 0x1 */
        l_0x1007_56f4:
            ii(0x1007_56f4, 3); mov(eax, memd[ss, ebp - 0x2c]);         /* mov eax, [ebp-0x2c] */
            ii(0x1007_56f7, 3); inc(memd[ss, ebp - 0x2c]);              /* inc dword [ebp-0x2c] */
            ii(0x1007_56fa, 5); jmp(0x1007_565a, -0xa5); goto l_0x1007_565a; /* jmp 0x1007565a */
        l_0x1007_56ff:
            ii(0x1007_56ff, 3); mov(eax, memd[ss, ebp - 0x20]);         /* mov eax, [ebp-0x20] */
            ii(0x1007_5702, 3); inc(memd[ss, ebp - 0x20]);              /* inc dword [ebp-0x20] */
            ii(0x1007_5705, 5); jmp(0x1007_563d, -0xcd); goto l_0x1007_563d; /* jmp 0x1007563d */
        l_0x1007_570a:
            ii(0x1007_570a, 4); movsx(eax, memw[ss, ebp - 0x10]);       /* movsx eax, word [ebp-0x10] */
            ii(0x1007_570e, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1007_5710, 2); if(jz(0x1007_573d, 0x2b)) goto l_0x1007_573d; /* jz 0x1007573d */
            ii(0x1007_5712, 4); movsx(eax, memw[ss, ebp - 0x10]);       /* movsx eax, word [ebp-0x10] */
            ii(0x1007_5716, 3); cmp(eax, 0x1);                          /* cmp eax, 0x1 */
            ii(0x1007_5719, 2); if(jnz(0x1007_5725, 0xa)) goto l_0x1007_5725; /* jnz 0x10075725 */
            ii(0x1007_571b, 3); mov(eax, memd[ss, ebp - 0x24]);         /* mov eax, [ebp-0x24] */
            ii(0x1007_571e, 5); call(0x1014_b6bd, 0xd_5f9a);            /* call 0x1014b6bd */
            ii(0x1007_5723, 2); jmp(0x1007_572d, 0x8); goto l_0x1007_572d; /* jmp 0x1007572d */
        l_0x1007_5725:
            ii(0x1007_5725, 3); mov(eax, memd[ss, ebp - 0x24]);         /* mov eax, [ebp-0x24] */
            ii(0x1007_5728, 5); call(0x1007_5c12, 0x4e5);               /* call 0x10075c12 */
        l_0x1007_572d:
            ii(0x1007_572d, 3); mov(eax, memd[ss, ebp - 0x24]);         /* mov eax, [ebp-0x24] */
            ii(0x1007_5730, 3); cmp(eax, memd[ss, ebp - 0x8]);          /* cmp eax, [ebp-0x8] */
            ii(0x1007_5733, 2); if(jz(0x1007_573d, 0x8)) goto l_0x1007_573d; /* jz 0x1007573d */
            ii(0x1007_5735, 3); mov(eax, memd[ss, ebp - 0x24]);         /* mov eax, [ebp-0x24] */
            ii(0x1007_5738, 5); call(0x100f_f637, 0x8_9efa);            /* call 0x100ff637 */
        l_0x1007_573d:
            ii(0x1007_573d, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1007_573f, 1); pop(ebp);                               /* pop ebp */
            ii(0x1007_5740, 1); pop(edi);                               /* pop edi */
            ii(0x1007_5741, 1); pop(esi);                               /* pop esi */
            ii(0x1007_5742, 1); pop(ecx);                               /* pop ecx */
            ii(0x1007_5743, 1); pop(ebx);                               /* pop ebx */
            ii(0x1007_5744, 1); ret();                                  /* ret */
        }
    }
}
