using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_173a-220635d6")]
        public void Method_1007_173a()
        {
            ii(0x1007_173a, 5);  push(0x28);                           /* push 0x28 */
            ii(0x1007_173f, 5);  call(Definitions.sys_check_available_stack_size, 0xf_460e);/* call 0x10165d52 */
            ii(0x1007_1744, 1);  push(ebx);                            /* push ebx */
            ii(0x1007_1745, 1);  push(ecx);                            /* push ecx */
            ii(0x1007_1746, 1);  push(edx);                            /* push edx */
            ii(0x1007_1747, 1);  push(esi);                            /* push esi */
            ii(0x1007_1748, 1);  push(edi);                            /* push edi */
            ii(0x1007_1749, 1);  push(ebp);                            /* push ebp */
            ii(0x1007_174a, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1007_174c, 6);  sub(esp, 0xc);                        /* sub esp, 0xc */
            ii(0x1007_1752, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1007_1755, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_1758, 5);  cmp(memw[ds, eax + 8], 0x42);         /* cmp word [eax+0x8], 0x42 */
            ii(0x1007_175d, 2);  if(jz(0x1007_176f, 0x10)) goto l_0x1007_176f;/* jz 0x1007176f */
            ii(0x1007_175f, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_1762, 5);  call(0x1016_433b, 0xf_2bd4);          /* call 0x1016433b */
            ii(0x1007_1767, 2);  test(al, al);                         /* test al, al */
            ii(0x1007_1769, 6);  if(jz(0x1007_1801, 0x92)) goto l_0x1007_1801;/* jz 0x10071801 */
        l_0x1007_176f:
            ii(0x1007_176f, 7);  mov(memd[ss, ebp - 12], 0);           /* mov dword [ebp-0xc], 0x0 */
            ii(0x1007_1776, 2);  jmp(0x1007_177e, 6); goto l_0x1007_177e;/* jmp 0x1007177e */
        l_0x1007_1778:
            ii(0x1007_1778, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1007_177b, 3);  inc(memd[ss, ebp - 12]);              /* inc dword [ebp-0xc] */
        l_0x1007_177e:
            ii(0x1007_177e, 4);  movsx(eax, memw[ss, ebp - 12]);       /* movsx eax, word [ebp-0xc] */
            ii(0x1007_1782, 3);  cmp(eax, 4);                          /* cmp eax, 0x4 */
            ii(0x1007_1785, 2);  if(jge(0x1007_17e5, 0x5e)) goto l_0x1007_17e5;/* jge 0x100717e5 */
            ii(0x1007_1787, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_178a, 3);  mov(al, memb[ds, eax + 38]);          /* mov al, [eax+0x26] */
            ii(0x1007_178d, 5);  and(eax, 0xff);                       /* and eax, 0xff */
            ii(0x1007_1792, 4);  movsx(edx, memw[ss, ebp - 12]);       /* movsx edx, word [ebp-0xc] */
            ii(0x1007_1796, 2);  cmp(edx, eax);                        /* cmp edx, eax */
            ii(0x1007_1798, 2);  if(jz(0x1007_17b3, 0x19)) goto l_0x1007_17b3;/* jz 0x100717b3 */
            ii(0x1007_179a, 4);  movsx(eax, memw[ss, ebp - 12]);       /* movsx eax, word [ebp-0xc] */
            ii(0x1007_179e, 6);  imul(eax, eax, 0x247);                /* imul eax, eax, 0x247 */
            ii(0x1007_17a4, 6);  mov(al, memb[ds, eax + 0x101c_a490]); /* mov al, [eax+0x101ca490] */
            ii(0x1007_17aa, 5);  and(eax, 0xff);                       /* and eax, 0xff */
            ii(0x1007_17af, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1007_17b1, 2);  if(jnz(0x1007_17b5, 2)) goto l_0x1007_17b5;/* jnz 0x100717b5 */
        l_0x1007_17b3:
            ii(0x1007_17b3, 2);  jmp(0x1007_17c5, 0x10); goto l_0x1007_17c5;/* jmp 0x100717c5 */
        l_0x1007_17b5:
            ii(0x1007_17b5, 4);  movsx(edx, memw[ss, ebp - 12]);       /* movsx edx, word [ebp-0xc] */
            ii(0x1007_17b9, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_17bc, 5);  call(0x1007_6074, 0x48b3);            /* call 0x10076074 */
            ii(0x1007_17c1, 2);  test(al, al);                         /* test al, al */
            ii(0x1007_17c3, 2);  if(jnz(0x1007_17c7, 2)) goto l_0x1007_17c7;/* jnz 0x100717c7 */
        l_0x1007_17c5:
            ii(0x1007_17c5, 2);  jmp(0x1007_17e3, 0x1c); goto l_0x1007_17e3;/* jmp 0x100717e3 */
        l_0x1007_17c7:
            ii(0x1007_17c7, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_17ca, 5);  cmp(memw[ds, eax + 8], 0x42);         /* cmp word [eax+0x8], 0x42 */
            ii(0x1007_17cf, 2);  if(jnz(0x1007_17da, 9)) goto l_0x1007_17da;/* jnz 0x100717da */
            ii(0x1007_17d1, 7);  mov(memd[ss, ebp - 8], 4);            /* mov dword [ebp-0x8], 0x4 */
            ii(0x1007_17d8, 2);  jmp(0x1007_182c, 0x52); goto l_0x1007_182c;/* jmp 0x1007182c */
        l_0x1007_17da:
            ii(0x1007_17da, 7);  mov(memd[ss, ebp - 8], 8);            /* mov dword [ebp-0x8], 0x8 */
            ii(0x1007_17e1, 2);  jmp(0x1007_182c, 0x49); goto l_0x1007_182c;/* jmp 0x1007182c */
        l_0x1007_17e3:
            ii(0x1007_17e3, 2);  jmp(0x1007_1778, -0x6d); goto l_0x1007_1778;/* jmp 0x10071778 */
        l_0x1007_17e5:
            ii(0x1007_17e5, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_17e8, 5);  cmp(memw[ds, eax + 8], 0x42);         /* cmp word [eax+0x8], 0x42 */
            ii(0x1007_17ed, 2);  if(jnz(0x1007_17f8, 9)) goto l_0x1007_17f8;/* jnz 0x100717f8 */
            ii(0x1007_17ef, 7);  mov(memd[ss, ebp - 8], 1);            /* mov dword [ebp-0x8], 0x1 */
            ii(0x1007_17f6, 2);  jmp(0x1007_182c, 0x34); goto l_0x1007_182c;/* jmp 0x1007182c */
        l_0x1007_17f8:
            ii(0x1007_17f8, 7);  mov(memd[ss, ebp - 8], 2);            /* mov dword [ebp-0x8], 0x2 */
            ii(0x1007_17ff, 2);  jmp(0x1007_182c, 0x2b); goto l_0x1007_182c;/* jmp 0x1007182c */
        l_0x1007_1801:
            ii(0x1007_1801, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_1804, 4);  test(memb[ds, eax + 18], 0x40);       /* test byte [eax+0x12], 0x40 */
            ii(0x1007_1808, 2);  if(jz(0x1007_1813, 9)) goto l_0x1007_1813;/* jz 0x10071813 */
            ii(0x1007_180a, 7);  mov(memd[ss, ebp - 8], 0x10);         /* mov dword [ebp-0x8], 0x10 */
            ii(0x1007_1811, 2);  jmp(0x1007_182c, 0x19); goto l_0x1007_182c;/* jmp 0x1007182c */
        l_0x1007_1813:
            ii(0x1007_1813, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_1816, 4);  test(memb[ds, eax + 18], 0x80);       /* test byte [eax+0x12], 0x80 */
            ii(0x1007_181a, 2);  if(jz(0x1007_1825, 9)) goto l_0x1007_1825;/* jz 0x10071825 */
            ii(0x1007_181c, 7);  mov(memd[ss, ebp - 8], 8);            /* mov dword [ebp-0x8], 0x8 */
            ii(0x1007_1823, 2);  jmp(0x1007_182c, 7); goto l_0x1007_182c;/* jmp 0x1007182c */
        l_0x1007_1825:
            ii(0x1007_1825, 7);  mov(memd[ss, ebp - 8], 4);            /* mov dword [ebp-0x8], 0x4 */
        l_0x1007_182c:
            ii(0x1007_182c, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1007_182f, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1007_1831, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1007_1832, 1);  pop(edi);                             /* pop edi */
            ii(0x1007_1833, 1);  pop(esi);                             /* pop esi */
            ii(0x1007_1834, 1);  pop(edx);                             /* pop edx */
            ii(0x1007_1835, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1007_1836, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1007_1837, 1);  ret();                                /* ret */
        }
    }
}
