using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100f_e810-9035a485")]
        public void Method_100f_e810()
        {
            ii(0x100f_e810, 5);  mov(eax, 1);                          /* mov eax, 0x1 */
            ii(0x100f_e815, 5);  call(0x100f_4fa2, -0x9878);           /* call 0x100f4fa2 */
            ii(0x100f_e81a, 4);  movsx(edx, memw[ss, ebp - 12]);       /* movsx edx, word [ebp-0xc] */
            ii(0x100f_e81e, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x100f_e820, 5);  mov(al, memb[ds, 0x101c_37da]);       /* mov al, [0x101c37da] */
            ii(0x100f_e825, 2);  cmp(edx, eax);                        /* cmp edx, eax */
            ii(0x100f_e827, 2);  if(jz(0x100f_e85f, 0x36)) goto l_0x100f_e85f;/* jz 0x100fe85f */
            ii(0x100f_e829, 7);  cmp(memb[ds, 0x101c_388b], 0);        /* cmp byte [0x101c388b], 0x0 */
            ii(0x100f_e830, 2);  if(jz(0x100f_e83b, 9)) goto l_0x100f_e83b;/* jz 0x100fe83b */
            ii(0x100f_e832, 4);  movsx(eax, memw[ss, ebp - 12]);       /* movsx eax, word [ebp-0xc] */
            ii(0x100f_e836, 5);  call(0x100f_e1cd, -0x66e);            /* call 0x100fe1cd */
        l_0x100f_e83b:
            ii(0x100f_e83b, 3);  mov(al, memb[ss, ebp - 12]);          /* mov al, [ebp-0xc] */
            ii(0x100f_e83e, 5);  mov(memb[ds, 0x101c_37da], al);       /* mov [0x101c37da], al */
            ii(0x100f_e843, 5);  call(0x1007_6054, -0x8_87f4);         /* call 0x10076054 */
            ii(0x100f_e848, 2);  xor(ebx, ebx);                        /* xor ebx, ebx */
            ii(0x100f_e84a, 2);  mov(bl, al);                          /* mov bl, al */
            ii(0x100f_e84c, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x100f_e84e, 5);  mov(al, memb[ds, 0x101c_3920]);       /* mov al, [0x101c3920] */
            ii(0x100f_e853, 3);  movsx(edx, ax);                       /* movsx edx, ax */
            ii(0x100f_e856, 4);  movsx(eax, memw[ss, ebp - 12]);       /* movsx eax, word [ebp-0xc] */
            ii(0x100f_e85a, 5);  call(0x1007_1d59, -0x8_cb06);         /* call 0x10071d59 */
        l_0x100f_e85f:
            ii(0x100f_e85f, 4);  cmp(memb[ss, ebp - 8], 0xa);          /* cmp byte [ebp-0x8], 0xa */
            ii(0x100f_e863, 2);  if(jz(0x100f_e8a2, 0x3d)) goto l_0x100f_e8a2;/* jz 0x100fe8a2 */
            ii(0x100f_e865, 4);  movsx(eax, memw[ss, ebp - 12]);       /* movsx eax, word [ebp-0xc] */
            ii(0x100f_e869, 5);  call(0x100f_2ec7, -0xb9a7);           /* call 0x100f2ec7 */
            ii(0x100f_e86e, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100f_e870, 5);  mov(eax, 0x101c_37bc);                /* mov eax, 0x101c37bc */
            ii(0x100f_e875, 5);  call(0x1013_ad71, 0x3_c4f7);          /* call 0x1013ad71 */
            ii(0x100f_e87a, 2);  test(al, al);                         /* test al, al */
            ii(0x100f_e87c, 2);  if(jz(0x100f_e88f, 0x11)) goto l_0x100f_e88f;/* jz 0x100fe88f */
            ii(0x100f_e87e, 5);  mov(eax, 0x101c_37bc);                /* mov eax, 0x101c37bc */
            ii(0x100f_e883, 5);  call(0x1007_6600, -0x8_8288);         /* call 0x10076600 */
            ii(0x100f_e888, 5);  call(0x1010_094d, 0x20c0);            /* call 0x1010094d */
            ii(0x100f_e88d, 2);  jmp(0x100f_e8a2, 0x13); goto l_0x100f_e8a2;/* jmp 0x100fe8a2 */
        l_0x100f_e88f:
            ii(0x100f_e88f, 7);  cmp(memd[ds, 0x101c_37dc], 1);        /* cmp dword [0x101c37dc], 0x1 */
            ii(0x100f_e896, 2);  if(jnz(0x100f_e8a2, 0xa)) goto l_0x100f_e8a2;/* jnz 0x100fe8a2 */
            ii(0x100f_e898, 5);  mov(eax, 1);                          /* mov eax, 0x1 */
            ii(0x100f_e89d, 5);  call(0x1010_1374, 0x2ad2);            /* call 0x10101374 */
        l_0x100f_e8a2:
            ii(0x100f_e8a2, 5);  jmp_func(0x100f_e927, 0x80);          /* jmp 0x100fe927 */
        }
    }
}
