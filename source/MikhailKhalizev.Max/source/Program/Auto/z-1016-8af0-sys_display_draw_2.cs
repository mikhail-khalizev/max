using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1016_8af0-c6e048de")]
        public void /* sys */ sys_display_draw_2()
        {
            ii(0x1016_8af0, 1);  push(esi);                            /* push esi */
            ii(0x1016_8af1, 1);  push(edi);                            /* push edi */
            ii(0x1016_8af2, 3);  sub(esp, 4);                          /* sub esp, 0x4 */
            ii(0x1016_8af5, 2);  mov(edi, edx);                        /* mov edi, edx */
            ii(0x1016_8af7, 7);  cmp(memd[ds, 0x101b_ddbc], 0);        /* cmp dword [0x101bddbc], 0x0 */
            ii(0x1016_8afe, 2);  if(jnz(0x1016_8b0a, 0xa)) goto l_0x1016_8b0a;/* jnz 0x10168b0a */
            ii(0x1016_8b00, 5);  mov(eax, 0xffff_ffff);                /* mov eax, 0xffffffff */
            ii(0x1016_8b05, 5);  jmp(0x1016_8b8e, 0x84); goto l_0x1016_8b8e;/* jmp 0x10168b8e */
        l_0x1016_8b0a:
            ii(0x1016_8b0a, 2);  test(edi, edi);                       /* test edi, edi */
            ii(0x1016_8b0c, 2);  if(jnz(0x1016_8b23, 0x15)) goto l_0x1016_8b23;/* jnz 0x10168b23 */
            ii(0x1016_8b0e, 2);  test(ebx, ebx);                       /* test ebx, ebx */
            ii(0x1016_8b10, 2);  if(jnz(0x1016_8b16, 4)) goto l_0x1016_8b16;/* jnz 0x10168b16 */
            ii(0x1016_8b12, 2);  test(ecx, ecx);                       /* test ecx, ecx */
            ii(0x1016_8b14, 2);  if(jz(0x1016_8b23, 0xd)) goto l_0x1016_8b23;/* jz 0x10168b23 */
        l_0x1016_8b16:
            ii(0x1016_8b16, 5);  mov(eax, 0xffff_ffff);                /* mov eax, 0xffffffff */
            ii(0x1016_8b1b, 3);  add(esp, 4);                          /* add esp, 0x4 */
            ii(0x1016_8b1e, 1);  pop(edi);                             /* pop edi */
            ii(0x1016_8b1f, 1);  pop(esi);                             /* pop esi */
            ii(0x1016_8b20, 3);  ret(4); return;                       /* ret 0x4 */
        l_0x1016_8b23:
            ii(0x1016_8b23, 2);  mov(edx, esp);                        /* mov edx, esp */
            ii(0x1016_8b25, 5);  call(/* sys */ 0x1016_7f00, -0xc2a);  /* call 0x10167f00 */
            ii(0x1016_8b2a, 2);  mov(esi, eax);                        /* mov esi, eax */
            ii(0x1016_8b2c, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1016_8b2e, 2);  if(jnz(0x1016_8b3d, 0xd)) goto l_0x1016_8b3d;/* jnz 0x10168b3d */
            ii(0x1016_8b30, 5);  mov(eax, 0xffff_ffff);                /* mov eax, 0xffffffff */
            ii(0x1016_8b35, 3);  add(esp, 4);                          /* add esp, 0x4 */
            ii(0x1016_8b38, 1);  pop(edi);                             /* pop edi */
            ii(0x1016_8b39, 1);  pop(esi);                             /* pop esi */
            ii(0x1016_8b3a, 3);  ret(4); return;                       /* ret 0x4 */
        l_0x1016_8b3d:
            ii(0x1016_8b3d, 4);  test(memb[ds, eax + 6], 1);           /* test byte [eax+0x6], 0x1 */
            ii(0x1016_8b41, 2);  if(jnz(0x1016_8b50, 0xd)) goto l_0x1016_8b50;/* jnz 0x10168b50 */
            ii(0x1016_8b43, 5);  mov(eax, 0xffff_ffff);                /* mov eax, 0xffffffff */
            ii(0x1016_8b48, 3);  add(esp, 4);                          /* add esp, 0x4 */
            ii(0x1016_8b4b, 1);  pop(edi);                             /* pop edi */
            ii(0x1016_8b4c, 1);  pop(esi);                             /* pop esi */
            ii(0x1016_8b4d, 3);  ret(4); return;                       /* ret 0x4 */
        l_0x1016_8b50:
            ii(0x1016_8b50, 3);  mov(edx, memd[ds, eax + 72]);         /* mov edx, [eax+0x48] */
            ii(0x1016_8b53, 3);  cmp(edx, memd[ds, eax + 48]);         /* cmp edx, [eax+0x30] */
            ii(0x1016_8b56, 2);  if(jnz(0x1016_8b5d, 5)) goto l_0x1016_8b5d;/* jnz 0x10168b5d */
            ii(0x1016_8b58, 3);  mov(memd[ds, eax + 72], edi);         /* mov [eax+0x48], edi */
            ii(0x1016_8b5b, 2);  jmp(0x1016_8b6f, 0x12); goto l_0x1016_8b6f;/* jmp 0x10168b6f */
        l_0x1016_8b5d:
            ii(0x1016_8b5d, 3);  cmp(edx, memd[ds, eax + 52]);         /* cmp edx, [eax+0x34] */
            ii(0x1016_8b60, 2);  if(jnz(0x1016_8b67, 5)) goto l_0x1016_8b67;/* jnz 0x10168b67 */
            ii(0x1016_8b62, 3);  mov(memd[ds, eax + 72], ebx);         /* mov [eax+0x48], ebx */
            ii(0x1016_8b65, 2);  jmp(0x1016_8b6f, 8); goto l_0x1016_8b6f;/* jmp 0x10168b6f */
        l_0x1016_8b67:
            ii(0x1016_8b67, 3);  cmp(edx, memd[ds, eax + 56]);         /* cmp edx, [eax+0x38] */
            ii(0x1016_8b6a, 2);  if(jnz(0x1016_8b6f, 3)) goto l_0x1016_8b6f;/* jnz 0x10168b6f */
            ii(0x1016_8b6c, 3);  mov(memd[ds, eax + 72], ecx);         /* mov [eax+0x48], ecx */
        l_0x1016_8b6f:
            ii(0x1016_8b6f, 3);  mov(memd[ds, esi + 48], edi);         /* mov [esi+0x30], edi */
            ii(0x1016_8b72, 2);  push(0);                              /* push 0x0 */
            ii(0x1016_8b74, 3);  mov(memd[ds, esi + 52], ebx);         /* mov [esi+0x34], ebx */
            ii(0x1016_8b77, 2);  mov(eax, esi);                        /* mov eax, esi */
            ii(0x1016_8b79, 3);  mov(memd[ds, esi + 56], ecx);         /* mov [esi+0x38], ecx */
            ii(0x1016_8b7c, 4);  mov(ecx, memd[ss, esp + 20]);         /* mov ecx, [esp+0x14] */
            ii(0x1016_8b80, 4);  mov(edx, memd[ss, esp + 4]);          /* mov edx, [esp+0x4] */
            ii(0x1016_8b84, 3);  mov(ebx, memd[ds, esi + 72]);         /* mov ebx, [esi+0x48] */
            ii(0x1016_8b87, 5);  call(/* sys */ 0x1016_9b90, 0x1004);  /* call 0x10169b90 */
            ii(0x1016_8b8c, 2);  xor(eax, eax);                        /* xor eax, eax */
        l_0x1016_8b8e:
            ii(0x1016_8b8e, 3);  add(esp, 4);                          /* add esp, 0x4 */
            ii(0x1016_8b91, 1);  pop(edi);                             /* pop edi */
            ii(0x1016_8b92, 1);  pop(esi);                             /* pop esi */
            ii(0x1016_8b93, 3);  ret(4);                               /* ret 0x4 */
        }
    }
}
