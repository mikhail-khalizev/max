using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_d195-ad386753")]
        public void Method_1013_d195()
        {
            ii(0x1013_d195, 5);  push(0x2c);                           /* push 0x2c */
            ii(0x1013_d19a, 5);  call(Definitions.sys_check_available_stack_size, 0x2_8bb3);/* call 0x10165d52 */
            ii(0x1013_d19f, 1);  push(ecx);                            /* push ecx */
            ii(0x1013_d1a0, 1);  push(esi);                            /* push esi */
            ii(0x1013_d1a1, 1);  push(edi);                            /* push edi */
            ii(0x1013_d1a2, 1);  push(ebp);                            /* push ebp */
            ii(0x1013_d1a3, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1013_d1a5, 6);  sub(esp, 0x18);                       /* sub esp, 0x18 */
            ii(0x1013_d1ab, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1013_d1ae, 3);  mov(memb[ss, ebp - 4], dl);           /* mov [ebp-0x4], dl */
            ii(0x1013_d1b1, 3);  mov(memd[ss, ebp - 8], ebx);          /* mov [ebp-0x8], ebx */
            ii(0x1013_d1b4, 7);  mov(memd[ss, ebp - 16], 0x14);        /* mov dword [ebp-0x10], 0x14 */
        l_0x1013_d1bb:
            ii(0x1013_d1bb, 3);  dec(memd[ss, ebp - 16]);              /* dec dword [ebp-0x10] */
            ii(0x1013_d1be, 5);  cmp(memw[ss, ebp - 16], -1 /* 0xff */);/* cmp word [ebp-0x10], 0xffff */
            ii(0x1013_d1c3, 6);  if(jz(0x1013_d236, 0x6d)) goto l_0x1013_d236;/* jz 0x1013d236 */
            ii(0x1013_d1c9, 4);  movsx(eax, memw[ss, ebp - 16]);       /* movsx eax, word [ebp-0x10] */
            ii(0x1013_d1cd, 6);  imul(eax, eax, 0x91);                 /* imul eax, eax, 0x91 */
            ii(0x1013_d1d3, 3);  mov(edx, memd[ss, ebp - 12]);         /* mov edx, [ebp-0xc] */
            ii(0x1013_d1d6, 6);  add(edx, 0x251);                      /* add edx, 0x251 */
            ii(0x1013_d1dc, 2);  add(edx, eax);                        /* add edx, eax */
            ii(0x1013_d1de, 3);  mov(memd[ss, ebp - 20], edx);         /* mov [ebp-0x14], edx */
            ii(0x1013_d1e1, 3);  mov(eax, memd[ss, ebp - 20]);         /* mov eax, [ebp-0x14] */
            ii(0x1013_d1e4, 6);  cmp(memd[ds, eax], 0xffff);           /* cmp dword [eax], 0xffff */
            ii(0x1013_d1ea, 2);  if(jz(0x1013_d234, 0x48)) goto l_0x1013_d234;/* jz 0x1013d234 */
            ii(0x1013_d1ec, 3);  mov(eax, memd[ss, ebp - 20]);         /* mov eax, [ebp-0x14] */
            ii(0x1013_d1ef, 3);  mov(al, memb[ds, eax + 6]);           /* mov al, [eax+0x6] */
            ii(0x1013_d1f2, 3);  cmp(al, memb[ss, ebp - 4]);           /* cmp al, [ebp-0x4] */
            ii(0x1013_d1f5, 2);  if(jz(0x1013_d208, 0x11)) goto l_0x1013_d208;/* jz 0x1013d208 */
            ii(0x1013_d1f7, 4);  cmp(memb[ss, ebp - 4], 2);            /* cmp byte [ebp-0x4], 0x2 */
            ii(0x1013_d1fb, 2);  if(jnz(0x1013_d206, 9)) goto l_0x1013_d206;/* jnz 0x1013d206 */
            ii(0x1013_d1fd, 3);  mov(eax, memd[ss, ebp - 20]);         /* mov eax, [ebp-0x14] */
            ii(0x1013_d200, 4);  cmp(memb[ds, eax + 6], 2);            /* cmp byte [eax+0x6], 0x2 */
            ii(0x1013_d204, 2);  if(jle(0x1013_d208, 2)) goto l_0x1013_d208;/* jle 0x1013d208 */
        l_0x1013_d206:
            ii(0x1013_d206, 2);  jmp(0x1013_d234, 0x2c); goto l_0x1013_d234;/* jmp 0x1013d234 */
        l_0x1013_d208:
            ii(0x1013_d208, 4);  movsx(edx, memw[ss, ebp - 8]);        /* movsx edx, word [ebp-0x8] */
            ii(0x1013_d20c, 3);  mov(eax, memd[ss, ebp - 20]);         /* mov eax, [ebp-0x14] */
            ii(0x1013_d20f, 3);  mov(eax, memd[ds, eax + 127]);        /* mov eax, [eax+0x7f] */
            ii(0x1013_d212, 3);  imul(eax, edx);                       /* imul eax, edx */
            ii(0x1013_d215, 5);  mov(ebx, 0x64);                       /* mov ebx, 0x64 */
            ii(0x1013_d21a, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1013_d21c, 2);  div(ebx);                             /* div ebx */
            ii(0x1013_d21e, 3);  mov(memd[ss, ebp - 24], eax);         /* mov [ebp-0x18], eax */
            ii(0x1013_d221, 3);  mov(ebx, memd[ss, ebp - 24]);         /* mov ebx, [ebp-0x18] */
            ii(0x1013_d224, 3);  mov(eax, memd[ss, ebp - 20]);         /* mov eax, [ebp-0x14] */
            ii(0x1013_d227, 2);  mov(edx, memd[ds, eax]);              /* mov edx, [eax] */
            ii(0x1013_d229, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1013_d22c, 3);  mov(eax, memd[ds, eax + 28]);         /* mov eax, [eax+0x1c] */
            ii(0x1013_d22f, 5);  call(/* sys */ 0x1018_07a7, 0x4_3573);/* call 0x101807a7 */
        l_0x1013_d234:
            ii(0x1013_d234, 2);  jmp(0x1013_d1bb, -0x7b); goto l_0x1013_d1bb;/* jmp 0x1013d1bb */
        l_0x1013_d236:
            ii(0x1013_d236, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1013_d238, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1013_d239, 1);  pop(edi);                             /* pop edi */
            ii(0x1013_d23a, 1);  pop(esi);                             /* pop esi */
            ii(0x1013_d23b, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1013_d23c, 1);  ret();                                /* ret */
        }
    }
}
