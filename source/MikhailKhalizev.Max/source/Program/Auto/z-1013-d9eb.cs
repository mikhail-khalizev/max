using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_d9eb-ea6ede45")]
        public void Method_1013_d9eb()
        {
            ii(0x1013_d9eb, 5);  push(0x2c);                           /* push 0x2c */
            ii(0x1013_d9f0, 5);  call(Definitions.sys_check_available_stack_size, 0x2_835d);/* call 0x10165d52 */
            ii(0x1013_d9f5, 1);  push(ecx);                            /* push ecx */
            ii(0x1013_d9f6, 1);  push(esi);                            /* push esi */
            ii(0x1013_d9f7, 1);  push(edi);                            /* push edi */
            ii(0x1013_d9f8, 1);  push(ebp);                            /* push ebp */
            ii(0x1013_d9f9, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1013_d9fb, 6);  sub(esp, 0x18);                       /* sub esp, 0x18 */
            ii(0x1013_da01, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1013_da04, 3);  mov(memd[ss, ebp - 8], edx);          /* mov [ebp-0x8], edx */
            ii(0x1013_da07, 3);  mov(memd[ss, ebp - 4], ebx);          /* mov [ebp-0x4], ebx */
            ii(0x1013_da0a, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1013_da0d, 4);  cmp(memd[ds, eax + 4], 0);            /* cmp dword [eax+0x4], 0x0 */
            ii(0x1013_da11, 2);  if(jz(0x1013_da20, 0xd)) goto l_0x1013_da20;/* jz 0x1013da20 */
            ii(0x1013_da13, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1013_da16, 4);  mov(ax, memw[ds, eax + 16]);          /* mov ax, [eax+0x10] */
            ii(0x1013_da1a, 4);  cmp(ax, memw[ss, ebp - 8]);           /* cmp ax, [ebp-0x8] */
            ii(0x1013_da1e, 2);  if(jge(0x1013_da22, 2)) goto l_0x1013_da22;/* jge 0x1013da22 */
        l_0x1013_da20:
            ii(0x1013_da20, 2);  jmp(0x1013_da2f, 0xd); goto l_0x1013_da2f;/* jmp 0x1013da2f */
        l_0x1013_da22:
            ii(0x1013_da22, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1013_da25, 4);  mov(ax, memw[ds, eax + 16]);          /* mov ax, [eax+0x10] */
            ii(0x1013_da29, 4);  cmp(ax, memw[ss, ebp - 4]);           /* cmp ax, [ebp-0x4] */
            ii(0x1013_da2d, 2);  if(jle(0x1013_da31, 2)) goto l_0x1013_da31;/* jle 0x1013da31 */
        l_0x1013_da2f:
            ii(0x1013_da2f, 2);  jmp(0x1013_da52, 0x21); goto l_0x1013_da52;/* jmp 0x1013da52 */
        l_0x1013_da31:
            ii(0x1013_da31, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1013_da34, 3);  mov(edx, memd[ds, eax + 4]);          /* mov edx, [eax+0x4] */
            ii(0x1013_da37, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1013_da3a, 5);  call(0x1013_ce3f, -0xc00);            /* call 0x1013ce3f */
            ii(0x1013_da3f, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1013_da42, 7);  mov(memd[ds, eax + 4], 0);            /* mov dword [eax+0x4], 0x0 */
            ii(0x1013_da49, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1013_da4c, 6);  mov(memw[ds, eax + 16], 0xffff);      /* mov word [eax+0x10], 0xffff */
        l_0x1013_da52:
            ii(0x1013_da52, 7);  mov(memd[ss, ebp - 20], 0);           /* mov dword [ebp-0x14], 0x0 */
            ii(0x1013_da59, 7);  mov(memd[ss, ebp - 16], 0);           /* mov dword [ebp-0x10], 0x0 */
            ii(0x1013_da60, 2);  jmp(0x1013_da68, 6); goto l_0x1013_da68;/* jmp 0x1013da68 */
        l_0x1013_da62:
            ii(0x1013_da62, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1013_da65, 3);  inc(memd[ss, ebp - 16]);              /* inc dword [ebp-0x10] */
        l_0x1013_da68:
            ii(0x1013_da68, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x1013_da6a, 5);  mov(al, memb[ds, 0x101c_7298]);       /* mov al, [0x101c7298] */
            ii(0x1013_da6f, 4);  movsx(edx, memw[ss, ebp - 16]);       /* movsx edx, word [ebp-0x10] */
            ii(0x1013_da73, 2);  cmp(edx, eax);                        /* cmp edx, eax */
            ii(0x1013_da75, 2);  if(jge(0x1013_dadb, 0x64)) goto l_0x1013_dadb;/* jge 0x1013dadb */
            ii(0x1013_da77, 4);  movsx(eax, memw[ss, ebp - 16]);       /* movsx eax, word [ebp-0x10] */
            ii(0x1013_da7b, 3);  imul(eax, eax, 0x1c);                 /* imul eax, eax, 0x1c */
            ii(0x1013_da7e, 5);  mov(edx, 0x101c_7299);                /* mov edx, 0x101c7299 */
            ii(0x1013_da83, 2);  add(edx, eax);                        /* add edx, eax */
            ii(0x1013_da85, 3);  mov(memd[ss, ebp - 24], edx);         /* mov [ebp-0x18], edx */
            ii(0x1013_da88, 3);  mov(eax, memd[ss, ebp - 24]);         /* mov eax, [ebp-0x18] */
            ii(0x1013_da8b, 4);  cmp(memb[ds, eax + 10], 3);           /* cmp byte [eax+0xa], 0x3 */
            ii(0x1013_da8f, 2);  if(jnz(0x1013_da9f, 0xe)) goto l_0x1013_da9f;/* jnz 0x1013da9f */
            ii(0x1013_da91, 3);  mov(eax, memd[ss, ebp - 24]);         /* mov eax, [ebp-0x18] */
            ii(0x1013_da94, 3);  movsx(edx, memw[ds, eax]);            /* movsx edx, word [eax] */
            ii(0x1013_da97, 4);  movsx(eax, memw[ss, ebp - 8]);        /* movsx eax, word [ebp-0x8] */
            ii(0x1013_da9b, 2);  cmp(edx, eax);                        /* cmp edx, eax */
            ii(0x1013_da9d, 2);  if(jge(0x1013_daa1, 2)) goto l_0x1013_daa1;/* jge 0x1013daa1 */
        l_0x1013_da9f:
            ii(0x1013_da9f, 2);  jmp(0x1013_daaf, 0xe); goto l_0x1013_daaf;/* jmp 0x1013daaf */
        l_0x1013_daa1:
            ii(0x1013_daa1, 3);  mov(eax, memd[ss, ebp - 24]);         /* mov eax, [ebp-0x18] */
            ii(0x1013_daa4, 3);  movsx(edx, memw[ds, eax]);            /* movsx edx, word [eax] */
            ii(0x1013_daa7, 4);  movsx(eax, memw[ss, ebp - 4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x1013_daab, 2);  cmp(edx, eax);                        /* cmp edx, eax */
            ii(0x1013_daad, 2);  if(jle(0x1013_dad9, 0x2a)) goto l_0x1013_dad9;/* jle 0x1013dad9 */
        l_0x1013_daaf:
            ii(0x1013_daaf, 3);  mov(eax, memd[ss, ebp - 20]);         /* mov eax, [ebp-0x14] */
            ii(0x1013_dab2, 4);  cmp(ax, memw[ss, ebp - 16]);          /* cmp ax, [ebp-0x10] */
            ii(0x1013_dab6, 2);  if(jz(0x1013_dad3, 0x1b)) goto l_0x1013_dad3;/* jz 0x1013dad3 */
            ii(0x1013_dab8, 5);  mov(ebx, 0x1c);                       /* mov ebx, 0x1c */
            ii(0x1013_dabd, 3);  mov(edx, memd[ss, ebp - 24]);         /* mov edx, [ebp-0x18] */
            ii(0x1013_dac0, 4);  movsx(eax, memw[ss, ebp - 20]);       /* movsx eax, word [ebp-0x14] */
            ii(0x1013_dac4, 3);  imul(eax, eax, 0x1c);                 /* imul eax, eax, 0x1c */
            ii(0x1013_dac7, 5);  mov(ecx, 0x101c_7299);                /* mov ecx, 0x101c7299 */
            ii(0x1013_dacc, 2);  add(eax, ecx);                        /* add eax, ecx */
            ii(0x1013_dace, 5);  call(Definitions.sys_memcpy, 0x2_8378);/* call 0x10165e4b */
        l_0x1013_dad3:
            ii(0x1013_dad3, 3);  mov(eax, memd[ss, ebp - 20]);         /* mov eax, [ebp-0x14] */
            ii(0x1013_dad6, 3);  inc(memd[ss, ebp - 20]);              /* inc dword [ebp-0x14] */
        l_0x1013_dad9:
            ii(0x1013_dad9, 2);  jmp(0x1013_da62, -0x79); goto l_0x1013_da62;/* jmp 0x1013da62 */
        l_0x1013_dadb:
            ii(0x1013_dadb, 3);  mov(al, memb[ss, ebp - 20]);          /* mov al, [ebp-0x14] */
            ii(0x1013_dade, 5);  mov(memb[ds, 0x101c_7298], al);       /* mov [0x101c7298], al */
            ii(0x1013_dae3, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1013_dae5, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1013_dae6, 1);  pop(edi);                             /* pop edi */
            ii(0x1013_dae7, 1);  pop(esi);                             /* pop esi */
            ii(0x1013_dae8, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1013_dae9, 1);  ret();                                /* ret */
        }
    }
}
