using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1011_bf10-f272b613")]
        public void Method_1011_bf10()
        {
            ii(0x1011_bf10, 5);  push(0x2c);                           /* push 0x2c */
            ii(0x1011_bf15, 5);  call(Definitions.sys_check_available_stack_size, 0x4_9e38);/* call 0x10165d52 */
            ii(0x1011_bf1a, 1);  push(ecx);                            /* push ecx */
            ii(0x1011_bf1b, 1);  push(esi);                            /* push esi */
            ii(0x1011_bf1c, 1);  push(edi);                            /* push edi */
            ii(0x1011_bf1d, 1);  push(ebp);                            /* push ebp */
            ii(0x1011_bf1e, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1011_bf20, 6);  sub(esp, 0x18);                       /* sub esp, 0x18 */
            ii(0x1011_bf26, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1011_bf29, 3);  mov(memd[ss, ebp - 8], edx);          /* mov [ebp-0x8], edx */
            ii(0x1011_bf2c, 3);  mov(memb[ss, ebp - 4], bl);           /* mov [ebp-0x4], bl */
            ii(0x1011_bf2f, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_bf32, 3);  movsx(edx, memw[ds, eax]);            /* movsx edx, word [eax] */
            ii(0x1011_bf35, 3);  shl(edx, 2);                          /* shl edx, 0x2 */
            ii(0x1011_bf38, 5);  mov(eax, memd[ds, 0x101c_5368]);      /* mov eax, [0x101c5368] */
            ii(0x1011_bf3d, 2);  add(edx, eax);                        /* add edx, eax */
            ii(0x1011_bf3f, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_bf42, 2);  mov(eax, memd[ds, eax]);              /* mov eax, [eax] */
            ii(0x1011_bf44, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x1011_bf47, 2);  mov(edx, memd[ds, edx]);              /* mov edx, [edx] */
            ii(0x1011_bf49, 2);  add(eax, edx);                        /* add eax, edx */
            ii(0x1011_bf4b, 2);  mov(al, memb[ds, eax]);               /* mov al, [eax] */
            ii(0x1011_bf4d, 3);  mov(memb[ss, ebp - 16], al);          /* mov [ebp-0x10], al */
            ii(0x1011_bf50, 6);  inc(memd[ds, 0x101c_52ec]);           /* inc dword [0x101c52ec] */
            ii(0x1011_bf56, 4);  cmp(memb[ss, ebp - 4], 0);            /* cmp byte [ebp-0x4], 0x0 */
            ii(0x1011_bf5a, 2);  if(jz(0x1011_bfab, 0x4f)) goto l_0x1011_bfab;/* jz 0x1011bfab */
            ii(0x1011_bf5c, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1011_bf5f, 3);  movsx(edx, memw[ds, eax]);            /* movsx edx, word [eax] */
            ii(0x1011_bf62, 3);  shl(edx, 2);                          /* shl edx, 0x2 */
            ii(0x1011_bf65, 5);  mov(eax, memd[ds, 0x101c_5368]);      /* mov eax, [0x101c5368] */
            ii(0x1011_bf6a, 2);  add(edx, eax);                        /* add edx, eax */
            ii(0x1011_bf6c, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1011_bf6f, 2);  mov(eax, memd[ds, eax]);              /* mov eax, [eax] */
            ii(0x1011_bf71, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x1011_bf74, 2);  mov(edx, memd[ds, edx]);              /* mov edx, [edx] */
            ii(0x1011_bf76, 2);  add(eax, edx);                        /* add eax, edx */
            ii(0x1011_bf78, 2);  mov(al, memb[ds, eax]);               /* mov al, [eax] */
            ii(0x1011_bf7a, 3);  mov(memb[ss, ebp - 20], al);          /* mov [ebp-0x14], al */
            ii(0x1011_bf7d, 4);  test(memb[ss, ebp - 16], 0x40);       /* test byte [ebp-0x10], 0x40 */
            ii(0x1011_bf81, 2);  if(jz(0x1011_bf89, 6)) goto l_0x1011_bf89;/* jz 0x1011bf89 */
            ii(0x1011_bf83, 4);  test(memb[ss, ebp - 20], 0x80);       /* test byte [ebp-0x14], 0x80 */
            ii(0x1011_bf87, 2);  if(jnz(0x1011_bf8b, 2)) goto l_0x1011_bf8b;/* jnz 0x1011bf8b */
        l_0x1011_bf89:
            ii(0x1011_bf89, 2);  jmp(0x1011_bf94, 9); goto l_0x1011_bf94;/* jmp 0x1011bf94 */
        l_0x1011_bf8b:
            ii(0x1011_bf8b, 7);  mov(memd[ss, ebp - 24], 0);           /* mov dword [ebp-0x18], 0x0 */
            ii(0x1011_bf92, 2);  jmp(0x1011_bfb5, 0x21); goto l_0x1011_bfb5;/* jmp 0x1011bfb5 */
        l_0x1011_bf94:
            ii(0x1011_bf94, 4);  test(memb[ss, ebp - 20], 0x40);       /* test byte [ebp-0x14], 0x40 */
            ii(0x1011_bf98, 2);  if(jz(0x1011_bfa0, 6)) goto l_0x1011_bfa0;/* jz 0x1011bfa0 */
            ii(0x1011_bf9a, 4);  test(memb[ss, ebp - 16], 0x80);       /* test byte [ebp-0x10], 0x80 */
            ii(0x1011_bf9e, 2);  if(jnz(0x1011_bfa2, 2)) goto l_0x1011_bfa2;/* jnz 0x1011bfa2 */
        l_0x1011_bfa0:
            ii(0x1011_bfa0, 2);  jmp(0x1011_bfab, 9); goto l_0x1011_bfab;/* jmp 0x1011bfab */
        l_0x1011_bfa2:
            ii(0x1011_bfa2, 7);  mov(memd[ss, ebp - 24], 0);           /* mov dword [ebp-0x18], 0x0 */
            ii(0x1011_bfa9, 2);  jmp(0x1011_bfb5, 0xa); goto l_0x1011_bfb5;/* jmp 0x1011bfb5 */
        l_0x1011_bfab:
            ii(0x1011_bfab, 3);  mov(al, memb[ss, ebp - 16]);          /* mov al, [ebp-0x10] */
            ii(0x1011_bfae, 2);  and(al, 0x1f);                        /* and al, 0x1f */
            ii(0x1011_bfb0, 2);  xor(ah, ah);                          /* xor ah, ah */
            ii(0x1011_bfb2, 3);  mov(memd[ss, ebp - 24], eax);         /* mov [ebp-0x18], eax */
        l_0x1011_bfb5:
            ii(0x1011_bfb5, 3);  mov(eax, memd[ss, ebp - 24]);         /* mov eax, [ebp-0x18] */
            ii(0x1011_bfb8, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1011_bfba, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1011_bfbb, 1);  pop(edi);                             /* pop edi */
            ii(0x1011_bfbc, 1);  pop(esi);                             /* pop esi */
            ii(0x1011_bfbd, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1011_bfbe, 1);  ret();                                /* ret */
        }
    }
}
