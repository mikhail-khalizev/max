using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1012_3b6c-dcba034b")]
        public void Method_1012_3b6c()
        {
            ii(0x1012_3b6c, 5);  push(0x20);                           /* push 0x20 */
            ii(0x1012_3b71, 5);  call(Definitions.sys_check_available_stack_size, 0x4_21dc);/* call 0x10165d52 */
            ii(0x1012_3b76, 1);  push(ebx);                            /* push ebx */
            ii(0x1012_3b77, 1);  push(esi);                            /* push esi */
            ii(0x1012_3b78, 1);  push(edi);                            /* push edi */
            ii(0x1012_3b79, 1);  push(ebp);                            /* push ebp */
            ii(0x1012_3b7a, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1012_3b7c, 6);  sub(esp, 0xc);                        /* sub esp, 0xc */
            ii(0x1012_3b82, 3);  mov(eax, memd[ss, ebp + 20]);         /* mov eax, [ebp+0x14] */
            ii(0x1012_3b85, 7);  cmp(memd[ds, eax + 164], 0);          /* cmp dword [eax+0xa4], 0x0 */
            ii(0x1012_3b8c, 2);  if(jz(0x1012_3b9c, 0xe)) goto l_0x1012_3b9c;/* jz 0x10123b9c */
            ii(0x1012_3b8e, 3);  mov(eax, memd[ss, ebp + 20]);         /* mov eax, [ebp+0x14] */
            ii(0x1012_3b91, 6);  mov(eax, memd[ds, eax + 164]);        /* mov eax, [eax+0xa4] */
            ii(0x1012_3b97, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1012_3b9a, 2);  jmp(0x1012_3ba8, 0xc); goto l_0x1012_3ba8;/* jmp 0x10123ba8 */
        l_0x1012_3b9c:
            ii(0x1012_3b9c, 3);  mov(eax, memd[ss, ebp + 20]);         /* mov eax, [ebp+0x14] */
            ii(0x1012_3b9f, 6);  mov(eax, memd[ds, eax + 160]);        /* mov eax, [eax+0xa0] */
            ii(0x1012_3ba5, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
        l_0x1012_3ba8:
            ii(0x1012_3ba8, 4);  cmp(memd[ss, ebp - 8], 0);            /* cmp dword [ebp-0x8], 0x0 */
            ii(0x1012_3bac, 2);  if(jnz(0x1012_3bba, 0xc)) goto l_0x1012_3bba;/* jnz 0x10123bba */
            ii(0x1012_3bae, 7);  mov(memd[ss, ebp - 12], 0);           /* mov dword [ebp-0xc], 0x0 */
            ii(0x1012_3bb5, 5);  jmp(0x1012_3c69, 0xaf); goto l_0x1012_3c69;/* jmp 0x10123c69 */
        l_0x1012_3bba:
            ii(0x1012_3bba, 7);  mov(memd[ss, ebp - 4], 0);            /* mov dword [ebp-0x4], 0x0 */
        l_0x1012_3bc1:
            ii(0x1012_3bc1, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1012_3bc4, 3);  cmp(memb[ds, eax], 0x20);             /* cmp byte [eax], 0x20 */
            ii(0x1012_3bc7, 2);  if(jnz(0x1012_3bd1, 8)) goto l_0x1012_3bd1;/* jnz 0x10123bd1 */
            ii(0x1012_3bc9, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1012_3bcc, 3);  inc(memd[ss, ebp - 8]);               /* inc dword [ebp-0x8] */
            ii(0x1012_3bcf, 2);  jmp(0x1012_3bc1, -0x10); goto l_0x1012_3bc1;/* jmp 0x10123bc1 */
        l_0x1012_3bd1:
            ii(0x1012_3bd1, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1012_3bd4, 2);  mov(al, memb[ds, eax]);               /* mov al, [eax] */
            ii(0x1012_3bd6, 5);  and(eax, 0xff);                       /* and eax, 0xff */
            ii(0x1012_3bdb, 3);  cmp(eax, 0xd);                        /* cmp eax, 0xd */
            ii(0x1012_3bde, 2);  if(jz(0x1012_3be8, 8)) goto l_0x1012_3be8;/* jz 0x10123be8 */
            ii(0x1012_3be0, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1012_3be3, 3);  cmp(memb[ds, eax], 0x2c);             /* cmp byte [eax], 0x2c */
            ii(0x1012_3be6, 2);  if(jnz(0x1012_3bea, 2)) goto l_0x1012_3bea;/* jnz 0x10123bea */
        l_0x1012_3be8:
            ii(0x1012_3be8, 2);  jmp(0x1012_3bf3, 9); goto l_0x1012_3bf3;/* jmp 0x10123bf3 */
        l_0x1012_3bea:
            ii(0x1012_3bea, 3);  mov(eax, memd[ss, ebp + 28]);         /* mov eax, [ebp+0x1c] */
            ii(0x1012_3bed, 1);  dec(eax);                             /* dec eax */
            ii(0x1012_3bee, 3);  cmp(eax, memd[ss, ebp - 4]);          /* cmp eax, [ebp-0x4] */
            ii(0x1012_3bf1, 2);  if(ja(0x1012_3bf5, 2)) goto l_0x1012_3bf5;/* ja 0x10123bf5 */
        l_0x1012_3bf3:
            ii(0x1012_3bf3, 2);  jmp(0x1012_3c0a, 0x15); goto l_0x1012_3c0a;/* jmp 0x10123c0a */
        l_0x1012_3bf5:
            ii(0x1012_3bf5, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1012_3bf8, 3);  inc(memd[ss, ebp - 8]);               /* inc dword [ebp-0x8] */
            ii(0x1012_3bfb, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1012_3bfe, 3);  inc(memd[ss, ebp - 4]);               /* inc dword [ebp-0x4] */
            ii(0x1012_3c01, 3);  add(edx, memd[ss, ebp + 24]);         /* add edx, [ebp+0x18] */
            ii(0x1012_3c04, 2);  mov(al, memb[ds, eax]);               /* mov al, [eax] */
            ii(0x1012_3c06, 2);  mov(memb[ds, edx], al);               /* mov [edx], al */
            ii(0x1012_3c08, 2);  jmp(0x1012_3bd1, -0x39); goto l_0x1012_3bd1;/* jmp 0x10123bd1 */
        l_0x1012_3c0a:
            ii(0x1012_3c0a, 3);  mov(eax, memd[ss, ebp + 24]);         /* mov eax, [ebp+0x18] */
            ii(0x1012_3c0d, 3);  add(eax, memd[ss, ebp - 4]);          /* add eax, [ebp-0x4] */
            ii(0x1012_3c10, 3);  mov(memb[ds, eax], 0);                /* mov byte [eax], 0x0 */
            ii(0x1012_3c13, 3);  mov(eax, memd[ss, ebp + 28]);         /* mov eax, [ebp+0x1c] */
            ii(0x1012_3c16, 1);  dec(eax);                             /* dec eax */
            ii(0x1012_3c17, 3);  cmp(eax, memd[ss, ebp - 4]);          /* cmp eax, [ebp-0x4] */
            ii(0x1012_3c1a, 2);  if(jnz(0x1012_3c3d, 0x21)) goto l_0x1012_3c3d;/* jnz 0x10123c3d */
        l_0x1012_3c1c:
            ii(0x1012_3c1c, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1012_3c1f, 2);  mov(al, memb[ds, eax]);               /* mov al, [eax] */
            ii(0x1012_3c21, 5);  and(eax, 0xff);                       /* and eax, 0xff */
            ii(0x1012_3c26, 3);  cmp(eax, 0xd);                        /* cmp eax, 0xd */
            ii(0x1012_3c29, 2);  if(jz(0x1012_3c33, 8)) goto l_0x1012_3c33;/* jz 0x10123c33 */
            ii(0x1012_3c2b, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1012_3c2e, 3);  cmp(memb[ds, eax], 0x2c);             /* cmp byte [eax], 0x2c */
            ii(0x1012_3c31, 2);  if(jnz(0x1012_3c35, 2)) goto l_0x1012_3c35;/* jnz 0x10123c35 */
        l_0x1012_3c33:
            ii(0x1012_3c33, 2);  jmp(0x1012_3c3d, 8); goto l_0x1012_3c3d;/* jmp 0x10123c3d */
        l_0x1012_3c35:
            ii(0x1012_3c35, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1012_3c38, 3);  inc(memd[ss, ebp - 8]);               /* inc dword [ebp-0x8] */
            ii(0x1012_3c3b, 2);  jmp(0x1012_3c1c, -0x21); goto l_0x1012_3c1c;/* jmp 0x10123c1c */
        l_0x1012_3c3d:
            ii(0x1012_3c3d, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1012_3c40, 3);  cmp(memb[ds, eax], 0x2c);             /* cmp byte [eax], 0x2c */
            ii(0x1012_3c43, 2);  if(jnz(0x1012_3c56, 0x11)) goto l_0x1012_3c56;/* jnz 0x10123c56 */
            ii(0x1012_3c45, 3);  inc(memd[ss, ebp - 8]);               /* inc dword [ebp-0x8] */
            ii(0x1012_3c48, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1012_3c4b, 3);  mov(edx, memd[ss, ebp + 20]);         /* mov edx, [ebp+0x14] */
            ii(0x1012_3c4e, 6);  mov(memd[ds, edx + 164], eax);        /* mov [edx+0xa4], eax */
            ii(0x1012_3c54, 2);  jmp(0x1012_3c62, 0xc); goto l_0x1012_3c62;/* jmp 0x10123c62 */
        l_0x1012_3c56:
            ii(0x1012_3c56, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1012_3c59, 3);  mov(edx, memd[ss, ebp + 20]);         /* mov edx, [ebp+0x14] */
            ii(0x1012_3c5c, 6);  mov(memd[ds, edx + 164], eax);        /* mov [edx+0xa4], eax */
        l_0x1012_3c62:
            ii(0x1012_3c62, 7);  mov(memd[ss, ebp - 12], 1);           /* mov dword [ebp-0xc], 0x1 */
        l_0x1012_3c69:
            ii(0x1012_3c69, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1012_3c6c, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1012_3c6e, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1012_3c6f, 1);  pop(edi);                             /* pop edi */
            ii(0x1012_3c70, 1);  pop(esi);                             /* pop esi */
            ii(0x1012_3c71, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1012_3c72, 1);  ret();                                /* ret */
        }
    }
}
