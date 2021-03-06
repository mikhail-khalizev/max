using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_e075-8122221f")]
        public void Method_1009_e075()
        {
            ii(0x1009_e075, 5);  push(0x50);                           /* push 0x50 */
            ii(0x1009_e07a, 5);  call(Definitions.sys_check_available_stack_size, 0xc_7cd3);/* call 0x10165d52 */
            ii(0x1009_e07f, 1);  push(ecx);                            /* push ecx */
            ii(0x1009_e080, 1);  push(esi);                            /* push esi */
            ii(0x1009_e081, 1);  push(edi);                            /* push edi */
            ii(0x1009_e082, 1);  push(ebp);                            /* push ebp */
            ii(0x1009_e083, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1009_e085, 6);  sub(esp, 0x30);                       /* sub esp, 0x30 */
            ii(0x1009_e08b, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1009_e08e, 3);  mov(memd[ss, ebp - 8], edx);          /* mov [ebp-0x8], edx */
            ii(0x1009_e091, 3);  mov(memb[ss, ebp - 4], bl);           /* mov [ebp-0x4], bl */
            ii(0x1009_e094, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1009_e097, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x1009_e09a, 4);  cmp(memb[ss, ebp - 4], 2);            /* cmp byte [ebp-0x4], 0x2 */
            ii(0x1009_e09e, 2);  if(jz(0x1009_e0ad, 0xd)) goto l_0x1009_e0ad;/* jz 0x1009e0ad */
            ii(0x1009_e0a0, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1009_e0a3, 5);  call(0x1009_e31c, 0x274);             /* call 0x1009e31c */
            ii(0x1009_e0a8, 5);  jmp(0x1009_e151, 0xa4); goto l_0x1009_e151;/* jmp 0x1009e151 */
        l_0x1009_e0ad:
            ii(0x1009_e0ad, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1009_e0b0, 3);  mov(memd[ss, ebp - 20], eax);         /* mov [ebp-0x14], eax */
            ii(0x1009_e0b3, 3);  mov(eax, memd[ss, ebp - 20]);         /* mov eax, [ebp-0x14] */
            ii(0x1009_e0b6, 4);  mov(ax, memw[ds, eax + 31]);          /* mov ax, [eax+0x1f] */
            ii(0x1009_e0ba, 3);  mov(memd[ss, ebp - 24], eax);         /* mov [ebp-0x18], eax */
            ii(0x1009_e0bd, 5);  mov(eax, 0x49);                       /* mov eax, 0x49 */
            ii(0x1009_e0c2, 5);  call(Definitions.sys_new, 0xc_7d39);  /* call 0x10165e00 */
            ii(0x1009_e0c7, 3);  mov(memd[ss, ebp - 28], eax);         /* mov [ebp-0x1c], eax */
            ii(0x1009_e0ca, 3);  mov(eax, memd[ss, ebp - 28]);         /* mov eax, [ebp-0x1c] */
            ii(0x1009_e0cd, 3);  mov(memd[ss, ebp - 32], eax);         /* mov [ebp-0x20], eax */
            ii(0x1009_e0d0, 4);  cmp(memd[ss, ebp - 32], 0);           /* cmp dword [ebp-0x20], 0x0 */
            ii(0x1009_e0d4, 2);  if(jz(0x1009_e122, 0x4c)) goto l_0x1009_e122;/* jz 0x1009e122 */
            ii(0x1009_e0d6, 5);  mov(eax, 0x1009_e158);                /* mov eax, 0x1009e158 */
            ii(0x1009_e0db, 1);  push(eax);                            /* push eax */
            ii(0x1009_e0dc, 3);  mov(eax, memd[ss, ebp - 20]);         /* mov eax, [ebp-0x14] */
            ii(0x1009_e0df, 3);  mov(eax, memd[ds, eax + 31]);         /* mov eax, [eax+0x1f] */
            ii(0x1009_e0e2, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x1009_e0e5, 3);  shl(eax, 2);                          /* shl eax, 0x2 */
            ii(0x1009_e0e8, 3);  mov(edx, memd[ss, ebp - 20]);         /* mov edx, [ebp-0x14] */
            ii(0x1009_e0eb, 3);  add(edx, 0x23);                       /* add edx, 0x23 */
            ii(0x1009_e0ee, 2);  add(edx, eax);                        /* add edx, eax */
            ii(0x1009_e0f0, 3);  lea(eax, memd[ss, ebp - 36]);         /* lea eax, [ebp-0x24] */
            ii(0x1009_e0f3, 5);  call(0x1007_5e64, -0x2_8294);         /* call 0x10075e64 */
            ii(0x1009_e0f8, 1);  push(eax);                            /* push eax */
            ii(0x1009_e0f9, 5);  mov(eax, 3);                          /* mov eax, 0x3 */
            ii(0x1009_e0fe, 1);  push(eax);                            /* push eax */
            ii(0x1009_e0ff, 3);  mov(eax, memd[ss, ebp - 24]);         /* mov eax, [ebp-0x18] */
            ii(0x1009_e102, 4);  imul(eax, memd[ss, ebp - 24]);        /* imul eax, [ebp-0x18] */
            ii(0x1009_e106, 3);  movsx(ecx, ax);                       /* movsx ecx, ax */
            ii(0x1009_e109, 3);  mov(ebx, memd[ss, ebp - 20]);         /* mov ebx, [ebp-0x14] */
            ii(0x1009_e10c, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x1009_e10f, 3);  mov(eax, memd[ss, ebp - 28]);         /* mov eax, [ebp-0x1c] */
            ii(0x1009_e112, 5);  call(0x100a_c220, 0xe109);            /* call 0x100ac220 */
            ii(0x1009_e117, 3);  mov(memd[ss, ebp - 40], eax);         /* mov [ebp-0x28], eax */
            ii(0x1009_e11a, 3);  mov(eax, memd[ss, ebp - 40]);         /* mov eax, [ebp-0x28] */
            ii(0x1009_e11d, 3);  mov(memd[ss, ebp - 44], eax);         /* mov [ebp-0x2c], eax */
            ii(0x1009_e120, 2);  jmp(0x1009_e128, 6); goto l_0x1009_e128;/* jmp 0x1009e128 */
        l_0x1009_e122:
            ii(0x1009_e122, 3);  mov(eax, memd[ss, ebp - 32]);         /* mov eax, [ebp-0x20] */
            ii(0x1009_e125, 3);  mov(memd[ss, ebp - 44], eax);         /* mov [ebp-0x2c], eax */
        l_0x1009_e128:
            ii(0x1009_e128, 3);  mov(edx, memd[ss, ebp - 44]);         /* mov edx, [ebp-0x2c] */
            ii(0x1009_e12b, 3);  lea(eax, memd[ss, ebp - 48]);         /* lea eax, [ebp-0x30] */
            ii(0x1009_e12e, 5);  call(0x1008_b060, -0x1_30d3);         /* call 0x1008b060 */
            ii(0x1009_e133, 3);  lea(eax, memd[ss, ebp - 48]);         /* lea eax, [ebp-0x30] */
            ii(0x1009_e136, 5);  call(0x1008_af84, -0x1_31b7);         /* call 0x1008af84 */
            ii(0x1009_e13b, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1009_e13d, 5);  mov(eax, 0x101c_3180);                /* mov eax, 0x101c3180 */
            ii(0x1009_e142, 5);  call(0x100a_4d50, 0x6c09);            /* call 0x100a4d50 */
            ii(0x1009_e147, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1009_e149, 3);  lea(eax, memd[ss, ebp - 48]);         /* lea eax, [ebp-0x30] */
            ii(0x1009_e14c, 5);  call(0x1008_8b7c, -0x1_55d5);         /* call 0x10088b7c */
        l_0x1009_e151:
            ii(0x1009_e151, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1009_e153, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1009_e154, 1);  pop(edi);                             /* pop edi */
            ii(0x1009_e155, 1);  pop(esi);                             /* pop esi */
            ii(0x1009_e156, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1009_e157, 1);  ret();                                /* ret */
        }
    }
}
