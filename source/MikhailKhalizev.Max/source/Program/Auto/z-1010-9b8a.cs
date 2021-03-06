using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1010_9b8a-4e3e4e68")]
        public void Method_1010_9b8a()
        {
            ii(0x1010_9b8a, 5);  push(0x24);                           /* push 0x24 */
            ii(0x1010_9b8f, 5);  call(Definitions.sys_check_available_stack_size, 0x5_c1be);/* call 0x10165d52 */
            ii(0x1010_9b94, 1);  push(ebx);                            /* push ebx */
            ii(0x1010_9b95, 1);  push(ecx);                            /* push ecx */
            ii(0x1010_9b96, 1);  push(edx);                            /* push edx */
            ii(0x1010_9b97, 1);  push(esi);                            /* push esi */
            ii(0x1010_9b98, 1);  push(edi);                            /* push edi */
            ii(0x1010_9b99, 1);  push(ebp);                            /* push ebp */
            ii(0x1010_9b9a, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1010_9b9c, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x1010_9ba2, 7);  cmp(memd[ds, 0x101c_4e48], 0);        /* cmp dword [0x101c4e48], 0x0 */
            ii(0x1010_9ba9, 6);  if(jz(0x1010_9c20, 0x71)) goto l_0x1010_9c20;/* jz 0x10109c20 */
        l_0x1010_9baf:
            ii(0x1010_9baf, 7);  dec(memw[ds, 0x101c_4e4c]);           /* dec word [0x101c4e4c] */
            ii(0x1010_9bb6, 8);  cmp(memw[ds, 0x101c_4e4c], -1 /* 0xff */);/* cmp word [0x101c4e4c], 0xffff */
            ii(0x1010_9bbe, 2);  if(jz(0x1010_9c11, 0x51)) goto l_0x1010_9c11;/* jz 0x10109c11 */
            ii(0x1010_9bc0, 5);  mov(eax, memd[ds, 0x101c_4e4a]);      /* mov eax, [0x101c4e4a] */
            ii(0x1010_9bc5, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x1010_9bc8, 3);  imul(edx, eax, 0x13);                 /* imul edx, eax, 0x13 */
            ii(0x1010_9bcb, 5);  mov(eax, memd[ds, 0x101c_4e48]);      /* mov eax, [0x101c4e48] */
            ii(0x1010_9bd0, 2);  add(eax, edx);                        /* add eax, edx */
            ii(0x1010_9bd2, 3);  cmp(memd[ds, eax], 0);                /* cmp dword [eax], 0x0 */
            ii(0x1010_9bd5, 2);  if(jz(0x1010_9c0f, 0x38)) goto l_0x1010_9c0f;/* jz 0x10109c0f */
            ii(0x1010_9bd7, 5);  mov(eax, memd[ds, 0x101c_4e4a]);      /* mov eax, [0x101c4e4a] */
            ii(0x1010_9bdc, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x1010_9bdf, 3);  imul(edx, eax, 0x13);                 /* imul edx, eax, 0x13 */
            ii(0x1010_9be2, 5);  mov(eax, memd[ds, 0x101c_4e48]);      /* mov eax, [0x101c4e48] */
            ii(0x1010_9be7, 2);  add(eax, edx);                        /* add eax, edx */
            ii(0x1010_9be9, 2);  mov(eax, memd[ds, eax]);              /* mov eax, [eax] */
            ii(0x1010_9beb, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1010_9bee, 4);  cmp(memd[ss, ebp - 8], 0);            /* cmp dword [ebp-0x8], 0x0 */
            ii(0x1010_9bf2, 2);  if(jz(0x1010_9c08, 0x14)) goto l_0x1010_9c08;/* jz 0x10109c08 */
            ii(0x1010_9bf4, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1010_9bf6, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1010_9bf9, 5);  call(Definitions.my_dtor_d2, -0x3_b6c6);/* call 0x100ce538 */
            ii(0x1010_9bfe, 5);  call(Definitions.sys_delete, 0x5_c361);/* call 0x10165f64 */
            ii(0x1010_9c03, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1010_9c06, 2);  jmp(0x1010_9c0f, 7); goto l_0x1010_9c0f;/* jmp 0x10109c0f */
        l_0x1010_9c08:
            ii(0x1010_9c08, 7);  mov(memd[ss, ebp - 4], 0);            /* mov dword [ebp-0x4], 0x0 */
        l_0x1010_9c0f:
            ii(0x1010_9c0f, 2);  jmp(0x1010_9baf, -0x62); goto l_0x1010_9baf;/* jmp 0x10109baf */
        l_0x1010_9c11:
            ii(0x1010_9c11, 10);  mov(memd[ds, 0x101c_4e48], 0);       /* mov dword [0x101c4e48], 0x0 */
            ii(0x1010_9c1b, 5);  call(0x1010_99a7, -0x279);            /* call 0x101099a7 */
        l_0x1010_9c20:
            ii(0x1010_9c20, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1010_9c22, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1010_9c23, 1);  pop(edi);                             /* pop edi */
            ii(0x1010_9c24, 1);  pop(esi);                             /* pop esi */
            ii(0x1010_9c25, 1);  pop(edx);                             /* pop edx */
            ii(0x1010_9c26, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1010_9c27, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1010_9c28, 1);  ret();                                /* ret */
        }
    }
}
