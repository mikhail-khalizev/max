using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_90f9-629d65b8")]
        public void Method_100a_90f9()
        {
            ii(0x100a_90f9, 5);  push(0x30);                           /* push 0x30 */
            ii(0x100a_90fe, 5);  call(Definitions.sys_check_available_stack_size, 0xb_cc4f);/* call 0x10165d52 */
            ii(0x100a_9103, 1);  push(esi);                            /* push esi */
            ii(0x100a_9104, 1);  push(edi);                            /* push edi */
            ii(0x100a_9105, 1);  push(ebp);                            /* push ebp */
            ii(0x100a_9106, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100a_9108, 6);  sub(esp, 0x20);                       /* sub esp, 0x20 */
            ii(0x100a_910e, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x100a_9111, 3);  mov(memd[ss, ebp - 12], edx);         /* mov [ebp-0xc], edx */
            ii(0x100a_9114, 3);  mov(memb[ss, ebp - 8], bl);           /* mov [ebp-0x8], bl */
            ii(0x100a_9117, 3);  mov(memb[ss, ebp - 4], cl);           /* mov [ebp-0x4], cl */
            ii(0x100a_911a, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100a_911d, 3);  mov(al, memb[ds, eax + 38]);          /* mov al, [eax+0x26] */
            ii(0x100a_9120, 5);  and(eax, 0xff);                       /* and eax, 0xff */
            ii(0x100a_9125, 6);  imul(eax, eax, 0x247);                /* imul eax, eax, 0x247 */
            ii(0x100a_912b, 6);  mov(al, memb[ds, eax + 0x101c_a490]); /* mov al, [eax+0x101ca490] */
            ii(0x100a_9131, 5);  and(eax, 0xff);                       /* and eax, 0xff */
            ii(0x100a_9136, 3);  cmp(eax, 2);                          /* cmp eax, 0x2 */
            ii(0x100a_9139, 2);  if(jnz(0x100a_9141, 6)) goto l_0x100a_9141;/* jnz 0x100a9141 */
            ii(0x100a_913b, 4);  cmp(memb[ss, ebp - 8], 0);            /* cmp byte [ebp-0x8], 0x0 */
            ii(0x100a_913f, 2);  if(jnz(0x100a_914a, 9)) goto l_0x100a_914a;/* jnz 0x100a914a */
        l_0x100a_9141:
            ii(0x100a_9141, 4);  mov(memb[ss, ebp - 20], 0);           /* mov byte [ebp-0x14], 0x0 */
            ii(0x100a_9145, 5);  jmp(0x100a_91ce, 0x84); goto l_0x100a_91ce;/* jmp 0x100a91ce */
        l_0x100a_914a:
            ii(0x100a_914a, 2);  xor(ecx, ecx);                        /* xor ecx, ecx */
            ii(0x100a_914c, 3);  mov(cl, memb[ss, ebp - 4]);           /* mov cl, [ebp-0x4] */
            ii(0x100a_914f, 4);  movsx(ebx, memb[ss, ebp - 8]);        /* movsx ebx, byte [ebp-0x8] */
            ii(0x100a_9153, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100a_9156, 3);  mov(edx, memd[ss, ebp - 16]);         /* mov edx, [ebp-0x10] */
            ii(0x100a_9159, 3);  mov(dl, memb[ds, edx + 38]);          /* mov dl, [edx+0x26] */
            ii(0x100a_915c, 6);  and(edx, 0xff);                       /* and edx, 0xff */
            ii(0x100a_9162, 6);  imul(edx, edx, 0xc5);                 /* imul edx, edx, 0xc5 */
            ii(0x100a_9168, 5);  mov(esi, 0x101c_31c4);                /* mov esi, 0x101c31c4 */
            ii(0x100a_916d, 2);  add(esi, edx);                        /* add esi, edx */
            ii(0x100a_916f, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x100a_9171, 2);  mov(eax, esi);                        /* mov eax, esi */
            ii(0x100a_9173, 5);  call(0x100c_1fd4, 0x1_8e5c);          /* call 0x100c1fd4 */
            ii(0x100a_9178, 3);  mov(memd[ss, ebp - 24], eax);         /* mov [ebp-0x18], eax */
            ii(0x100a_917b, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x100a_917d, 3);  mov(edx, memd[ss, ebp - 16]);         /* mov edx, [ebp-0x10] */
            ii(0x100a_9180, 3);  mov(al, memb[ds, edx + 77]);          /* mov al, [edx+0x4d] */
            ii(0x100a_9183, 3);  mov(memd[ss, ebp - 28], eax);         /* mov [ebp-0x1c], eax */
            ii(0x100a_9186, 4);  cmp(memb[ss, ebp - 8], 3);            /* cmp byte [ebp-0x8], 0x3 */
            ii(0x100a_918a, 2);  if(jnz(0x100a_9193, 7)) goto l_0x100a_9193;/* jnz 0x100a9193 */
            ii(0x100a_918c, 7);  mov(memd[ss, ebp - 28], 1);           /* mov dword [ebp-0x1c], 0x1 */
        l_0x100a_9193:
            ii(0x100a_9193, 4);  cmp(memd[ss, ebp - 24], 0);           /* cmp dword [ebp-0x18], 0x0 */
            ii(0x100a_9197, 2);  if(jz(0x100a_91bc, 0x23)) goto l_0x100a_91bc;/* jz 0x100a91bc */
            ii(0x100a_9199, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100a_919c, 3);  movsx(edx, memw[ds, eax]);            /* movsx edx, word [eax] */
            ii(0x100a_919f, 3);  shl(edx, 2);                          /* shl edx, 0x2 */
            ii(0x100a_91a2, 3);  add(edx, memd[ss, ebp - 24]);         /* add edx, [ebp-0x18] */
            ii(0x100a_91a5, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100a_91a8, 2);  mov(eax, memd[ds, eax]);              /* mov eax, [eax] */
            ii(0x100a_91aa, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x100a_91ad, 2);  add(eax, eax);                        /* add eax, eax */
            ii(0x100a_91af, 2);  mov(edx, memd[ds, edx]);              /* mov edx, [edx] */
            ii(0x100a_91b1, 2);  add(eax, edx);                        /* add eax, edx */
            ii(0x100a_91b3, 3);  mov(ax, memw[ds, eax]);               /* mov ax, [eax] */
            ii(0x100a_91b6, 4);  cmp(ax, memw[ss, ebp - 28]);          /* cmp ax, [ebp-0x1c] */
            ii(0x100a_91ba, 2);  if(jge(0x100a_91be, 2)) goto l_0x100a_91be;/* jge 0x100a91be */
        l_0x100a_91bc:
            ii(0x100a_91bc, 2);  jmp(0x100a_91c4, 6); goto l_0x100a_91c4;/* jmp 0x100a91c4 */
        l_0x100a_91be:
            ii(0x100a_91be, 4);  mov(memb[ss, ebp - 32], 1);           /* mov byte [ebp-0x20], 0x1 */
            ii(0x100a_91c2, 2);  jmp(0x100a_91c8, 4); goto l_0x100a_91c8;/* jmp 0x100a91c8 */
        l_0x100a_91c4:
            ii(0x100a_91c4, 4);  mov(memb[ss, ebp - 32], 0);           /* mov byte [ebp-0x20], 0x0 */
        l_0x100a_91c8:
            ii(0x100a_91c8, 3);  mov(al, memb[ss, ebp - 32]);          /* mov al, [ebp-0x20] */
            ii(0x100a_91cb, 3);  mov(memb[ss, ebp - 20], al);          /* mov [ebp-0x14], al */
        l_0x100a_91ce:
            ii(0x100a_91ce, 3);  mov(al, memb[ss, ebp - 20]);          /* mov al, [ebp-0x14] */
            ii(0x100a_91d1, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100a_91d3, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100a_91d4, 1);  pop(edi);                             /* pop edi */
            ii(0x100a_91d5, 1);  pop(esi);                             /* pop esi */
            ii(0x100a_91d6, 1);  ret();                                /* ret */
        }
    }
}
