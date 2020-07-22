using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1010_0e32-9574e8d1")]
        public void Method_1010_0e32()
        {
            ii(0x1010_0e32, 5);  push(0x20);                           /* push 0x20 */
            ii(0x1010_0e37, 5);  call(Definitions.sys_check_available_stack_size, 0x6_4f16);/* call 0x10165d52 */
            ii(0x1010_0e3c, 1);  push(ebx);                            /* push ebx */
            ii(0x1010_0e3d, 1);  push(ecx);                            /* push ecx */
            ii(0x1010_0e3e, 1);  push(esi);                            /* push esi */
            ii(0x1010_0e3f, 1);  push(edi);                            /* push edi */
            ii(0x1010_0e40, 1);  push(ebp);                            /* push ebp */
            ii(0x1010_0e41, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1010_0e43, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x1010_0e49, 3);  mov(memb[ss, ebp - 8], al);           /* mov [ebp-0x8], al */
            ii(0x1010_0e4c, 3);  mov(memb[ss, ebp - 4], dl);           /* mov [ebp-0x4], dl */
            ii(0x1010_0e4f, 4);  cmp(memb[ss, ebp - 8], 0);            /* cmp byte [ebp-0x8], 0x0 */
            ii(0x1010_0e53, 2);  if(jz(0x1010_0e5e, 9)) goto l_0x1010_0e5e;/* jz 0x10100e5e */
            ii(0x1010_0e55, 7);  cmp(memb[ds, 0x101c_391e], 3);        /* cmp byte [0x101c391e], 0x3 */
            ii(0x1010_0e5c, 2);  if(jnz(0x1010_0e60, 2)) goto l_0x1010_0e60;/* jnz 0x10100e60 */
        l_0x1010_0e5e:
            ii(0x1010_0e5e, 2);  jmp(0x1010_0e69, 9); goto l_0x1010_0e69;/* jmp 0x10100e69 */
        l_0x1010_0e60:
            ii(0x1010_0e60, 7);  cmp(memb[ds, 0x101c_391e], 7);        /* cmp byte [0x101c391e], 0x7 */
            ii(0x1010_0e67, 2);  if(jnz(0x1010_0e6b, 2)) goto l_0x1010_0e6b;/* jnz 0x10100e6b */
        l_0x1010_0e69:
            ii(0x1010_0e69, 2);  jmp(0x1010_0e74, 9); goto l_0x1010_0e74;/* jmp 0x10100e74 */
        l_0x1010_0e6b:
            ii(0x1010_0e6b, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x1010_0e6d, 5);  call(0x1010_0efe, 0x8c);              /* call 0x10100efe */
            ii(0x1010_0e72, 2);  jmp(0x1010_0ed2, 0x5e); goto l_0x1010_0ed2;/* jmp 0x10100ed2 */
        l_0x1010_0e74:
            ii(0x1010_0e74, 5);  call(0x1010_0da4, -0xd5);             /* call 0x10100da4 */
            ii(0x1010_0e79, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1010_0e7b, 2);  if(jz(0x1010_0e8f, 0x12)) goto l_0x1010_0e8f;/* jz 0x10100e8f */
            ii(0x1010_0e7d, 5);  mov(edx, 1);                          /* mov edx, 0x1 */
            ii(0x1010_0e82, 5);  mov(eax, memd[ds, 0x101c_3960]);      /* mov eax, [0x101c3960] */
            ii(0x1010_0e87, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x1010_0e8a, 5);  call(0x100f_334b, -0xdb44);           /* call 0x100f334b */
        l_0x1010_0e8f:
            ii(0x1010_0e8f, 7);  cmp(memd[ds, 0x101c_5624], 0);        /* cmp dword [0x101c5624], 0x0 */
            ii(0x1010_0e96, 2);  if(jz(0x1010_0eb2, 0x1a)) goto l_0x1010_0eb2;/* jz 0x10100eb2 */
            ii(0x1010_0e98, 5);  call(0x100e_42e4, -0x1_cbb9);         /* call 0x100e42e4 */
            ii(0x1010_0e9d, 5);  and(eax, 0xff);                       /* and eax, 0xff */
            ii(0x1010_0ea2, 5);  call(0x1012_8835, 0x2_798e);          /* call 0x10128835 */
            ii(0x1010_0ea7, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1010_0ea9, 2);  if(jz(0x1010_0eb0, 5)) goto l_0x1010_0eb0;/* jz 0x10100eb0 */
            ii(0x1010_0eab, 5);  call(0x1016_2cb8, 0x6_1e08);          /* call 0x10162cb8 */
        l_0x1010_0eb0:
            ii(0x1010_0eb0, 2);  jmp(0x1010_0ec3, 0x11); goto l_0x1010_0ec3;/* jmp 0x10100ec3 */
        l_0x1010_0eb2:
            ii(0x1010_0eb2, 5);  call(0x1014_82f4, 0x4_743d);          /* call 0x101482f4 */
            ii(0x1010_0eb7, 5);  mov(memd[ds, 0x101c_3974], eax);      /* mov [0x101c3974], eax */
            ii(0x1010_0ebc, 7);  mov(memb[ds, 0x101c_3978], 0);        /* mov byte [0x101c3978], 0x0 */
        l_0x1010_0ec3:
            ii(0x1010_0ec3, 5);  call(0x1016_2a8b, 0x6_1bc3);          /* call 0x10162a8b */
            ii(0x1010_0ec8, 5);  call(0x1011_fdcd, 0x1_ef00);          /* call 0x1011fdcd */
            ii(0x1010_0ecd, 5);  call(0x100a_9502, -0x5_79d0);         /* call 0x100a9502 */
        l_0x1010_0ed2:
            ii(0x1010_0ed2, 7);  cmp(memd[ds, 0x101c_5624], 0);        /* cmp dword [0x101c5624], 0x0 */
            ii(0x1010_0ed9, 2);  if(jz(0x1010_0eeb, 0x10)) goto l_0x1010_0eeb;/* jz 0x10100eeb */
            ii(0x1010_0edb, 5);  call(0x100f_ea2b, -0x24b5);           /* call 0x100fea2b */
            ii(0x1010_0ee0, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1010_0ee2, 2);  if(jz(0x1010_0eeb, 7)) goto l_0x1010_0eeb;/* jz 0x10100eeb */
            ii(0x1010_0ee4, 7);  mov(memb[ds, 0x101c_37d2], 1);        /* mov byte [0x101c37d2], 0x1 */
        l_0x1010_0eeb:
            ii(0x1010_0eeb, 4);  cmp(memb[ss, ebp - 4], 0);            /* cmp byte [ebp-0x4], 0x0 */
            ii(0x1010_0eef, 2);  if(jz(0x1010_0ef6, 5)) goto l_0x1010_0ef6;/* jz 0x10100ef6 */
            ii(0x1010_0ef1, 5);  call(0x100e_a903, -0x1_65f3);         /* call 0x100ea903 */
        l_0x1010_0ef6:
            ii(0x1010_0ef6, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1010_0ef8, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1010_0ef9, 1);  pop(edi);                             /* pop edi */
            ii(0x1010_0efa, 1);  pop(esi);                             /* pop esi */
            ii(0x1010_0efb, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1010_0efc, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1010_0efd, 1);  ret();                                /* ret */
        }
    }
}
