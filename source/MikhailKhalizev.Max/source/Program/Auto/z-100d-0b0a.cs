using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100d_0b0a-f5e630aa")]
        public void Method_100d_0b0a()
        {
            ii(0x100d_0b0a, 5);  push(0x48);                           /* push 0x48 */
            ii(0x100d_0b0f, 5);  call(Definitions.sys_check_available_stack_size, 0x9_523e);/* call 0x10165d52 */
            ii(0x100d_0b14, 1);  push(esi);                            /* push esi */
            ii(0x100d_0b15, 1);  push(edi);                            /* push edi */
            ii(0x100d_0b16, 1);  push(ebp);                            /* push ebp */
            ii(0x100d_0b17, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100d_0b19, 6);  sub(esp, 0x20);                       /* sub esp, 0x20 */
            ii(0x100d_0b1f, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x100d_0b22, 3);  mov(memd[ss, ebp - 12], edx);         /* mov [ebp-0xc], edx */
            ii(0x100d_0b25, 3);  mov(memd[ss, ebp - 8], ebx);          /* mov [ebp-0x8], ebx */
            ii(0x100d_0b28, 3);  mov(memd[ss, ebp - 4], ecx);          /* mov [ebp-0x4], ecx */
            ii(0x100d_0b2b, 3);  mov(eax, memd[ss, ebp + 28]);         /* mov eax, [ebp+0x1c] */
            ii(0x100d_0b2e, 1);  push(eax);                            /* push eax */
            ii(0x100d_0b2f, 3);  mov(eax, memd[ss, ebp + 24]);         /* mov eax, [ebp+0x18] */
            ii(0x100d_0b32, 1);  push(eax);                            /* push eax */
            ii(0x100d_0b33, 4);  movsx(eax, memw[ss, ebp + 20]);       /* movsx eax, word [ebp+0x14] */
            ii(0x100d_0b37, 1);  push(eax);                            /* push eax */
            ii(0x100d_0b38, 3);  mov(eax, memd[ss, ebp + 16]);         /* mov eax, [ebp+0x10] */
            ii(0x100d_0b3b, 3);  mov(al, memb[ds, eax + 38]);          /* mov al, [eax+0x26] */
            ii(0x100d_0b3e, 2);  xor(ah, ah);                          /* xor ah, ah */
            ii(0x100d_0b40, 1);  cwde();                               /* cwde */
            ii(0x100d_0b41, 1);  push(eax);                            /* push eax */
            ii(0x100d_0b42, 3);  mov(ecx, memd[ss, ebp - 4]);          /* mov ecx, [ebp-0x4] */
            ii(0x100d_0b45, 3);  mov(ebx, memd[ss, ebp - 8]);          /* mov ebx, [ebp-0x8] */
            ii(0x100d_0b48, 3);  mov(edx, memd[ss, ebp - 12]);         /* mov edx, [ebp-0xc] */
            ii(0x100d_0b4b, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100d_0b4e, 5);  call(0x100c_fe4d, -0xd06);            /* call 0x100cfe4d */
            ii(0x100d_0b53, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x100d_0b56, 3);  lea(eax, memd[ss, ebp - 16]);         /* lea eax, [ebp-0x10] */
            ii(0x100d_0b59, 3);  mov(memd[ss, ebp - 28], eax);         /* mov [ebp-0x1c], eax */
            ii(0x100d_0b5c, 3);  mov(eax, memd[ss, ebp + 16]);         /* mov eax, [ebp+0x10] */
            ii(0x100d_0b5f, 3);  mov(edx, memd[ss, ebp - 16]);         /* mov edx, [ebp-0x10] */
            ii(0x100d_0b62, 3);  mov(memd[ds, edx + 72], eax);         /* mov [edx+0x48], eax */
            ii(0x100d_0b65, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100d_0b68, 7);  mov(memd[ds, eax + 64], 0x101b_5ca4); /* mov dword [eax+0x40], 0x101b5ca4 */
            ii(0x100d_0b6f, 7);  mov(memd[ss, ebp - 20], 0x14);        /* mov dword [ebp-0x14], 0x14 */
            ii(0x100d_0b76, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100d_0b79, 4);  mov(ax, memw[ds, eax + 40]);          /* mov ax, [eax+0x28] */
            ii(0x100d_0b7d, 3);  shl(eax, 5);                          /* shl eax, 0x5 */
            ii(0x100d_0b80, 3);  mov(memd[ss, ebp - 24], eax);         /* mov [ebp-0x18], eax */
            ii(0x100d_0b83, 4);  movsx(eax, memw[ss, ebp - 20]);       /* movsx eax, word [ebp-0x14] */
            ii(0x100d_0b87, 4);  movsx(edx, memw[ss, ebp - 24]);       /* movsx edx, word [ebp-0x18] */
            ii(0x100d_0b8b, 3);  imul(eax, edx);                       /* imul eax, edx */
            ii(0x100d_0b8e, 3);  add(eax, 8);                          /* add eax, 0x8 */
            ii(0x100d_0b91, 5);  call(Definitions.sys_malloc, 0x9_a448);/* call 0x1016afde */
            ii(0x100d_0b96, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x100d_0b98, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100d_0b9b, 3);  mov(memd[ds, eax + 68], edx);         /* mov [eax+0x44], edx */
            ii(0x100d_0b9e, 3);  mov(edx, memd[ss, ebp - 16]);         /* mov edx, [ebp-0x10] */
            ii(0x100d_0ba1, 3);  mov(edx, memd[ds, edx + 68]);         /* mov edx, [edx+0x44] */
            ii(0x100d_0ba4, 3);  mov(eax, memd[ss, ebp - 20]);         /* mov eax, [ebp-0x14] */
            ii(0x100d_0ba7, 3);  mov(memw[ds, edx], ax);               /* mov [edx], ax */
            ii(0x100d_0baa, 3);  mov(edx, memd[ss, ebp - 16]);         /* mov edx, [ebp-0x10] */
            ii(0x100d_0bad, 3);  mov(edx, memd[ds, edx + 68]);         /* mov edx, [edx+0x44] */
            ii(0x100d_0bb0, 3);  mov(eax, memd[ss, ebp - 24]);         /* mov eax, [ebp-0x18] */
            ii(0x100d_0bb3, 4);  mov(memw[ds, edx + 2], ax);           /* mov [edx+0x2], ax */
            ii(0x100d_0bb7, 4);  movsx(eax, memw[ss, ebp - 20]);       /* movsx eax, word [ebp-0x14] */
            ii(0x100d_0bbb, 1);  push(eax);                            /* push eax */
            ii(0x100d_0bbc, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100d_0bbf, 3);  mov(eax, memd[ds, eax + 68]);         /* mov eax, [eax+0x44] */
            ii(0x100d_0bc2, 3);  add(eax, 8);                          /* add eax, 0x8 */
            ii(0x100d_0bc5, 1);  push(eax);                            /* push eax */
            ii(0x100d_0bc6, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_0bc9, 3);  mov(eax, memd[ds, eax + 14]);         /* mov eax, [eax+0xe] */
            ii(0x100d_0bcc, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x100d_0bcf, 1);  push(eax);                            /* push eax */
            ii(0x100d_0bd0, 4);  movsx(eax, memw[ss, ebp - 24]);       /* movsx eax, word [ebp-0x18] */
            ii(0x100d_0bd4, 1);  push(eax);                            /* push eax */
            ii(0x100d_0bd5, 4);  movsx(eax, memw[ss, ebp - 20]);       /* movsx eax, word [ebp-0x14] */
            ii(0x100d_0bd9, 1);  push(eax);                            /* push eax */
            ii(0x100d_0bda, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_0bdd, 3);  mov(eax, memd[ds, eax + 22]);         /* mov eax, [eax+0x16] */
            ii(0x100d_0be0, 3);  add(eax, 0x73);                       /* add eax, 0x73 */
            ii(0x100d_0be3, 1);  push(eax);                            /* push eax */
            ii(0x100d_0be4, 5);  call(/* sys */ 0x1016_abbc, 0x9_9fd3);/* call 0x1016abbc */
            ii(0x100d_0be9, 3);  add(esp, 0x18);                       /* add esp, 0x18 */
            ii(0x100d_0bec, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100d_0bef, 3);  mov(memd[ss, ebp - 32], eax);         /* mov [ebp-0x20], eax */
            ii(0x100d_0bf2, 3);  mov(eax, memd[ss, ebp - 32]);         /* mov eax, [ebp-0x20] */
            ii(0x100d_0bf5, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100d_0bf7, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100d_0bf8, 1);  pop(edi);                             /* pop edi */
            ii(0x100d_0bf9, 1);  pop(esi);                             /* pop esi */
            ii(0x100d_0bfa, 3);  ret(0x10);                            /* ret 0x10 */
        }
    }
}
