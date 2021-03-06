using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1011_7fb8-ad986594")]
        public void Method_1011_7fb8()
        {
            ii(0x1011_7fb8, 5);  push(0x34);                           /* push 0x34 */
            ii(0x1011_7fbd, 5);  call(Definitions.sys_check_available_stack_size, 0x4_dd90);/* call 0x10165d52 */
            ii(0x1011_7fc2, 1);  push(ebx);                            /* push ebx */
            ii(0x1011_7fc3, 1);  push(ecx);                            /* push ecx */
            ii(0x1011_7fc4, 1);  push(esi);                            /* push esi */
            ii(0x1011_7fc5, 1);  push(edi);                            /* push edi */
            ii(0x1011_7fc6, 1);  push(ebp);                            /* push ebp */
            ii(0x1011_7fc7, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1011_7fc9, 6);  sub(esp, 0x1c);                       /* sub esp, 0x1c */
            ii(0x1011_7fcf, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1011_7fd2, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1011_7fd5, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_7fd8, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1011_7fda, 3);  mov(dl, memb[ds, eax + 41]);          /* mov dl, [eax+0x29] */
            ii(0x1011_7fdd, 4);  movsx(eax, memw[ss, ebp - 4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x1011_7fe1, 2);  cmp(edx, eax);                        /* cmp edx, eax */
            ii(0x1011_7fe3, 2);  if(jnz(0x1011_7fee, 9)) goto l_0x1011_7fee;/* jnz 0x10117fee */
            ii(0x1011_7fe5, 4);  mov(memb[ss, ebp - 12], 0);           /* mov byte [ebp-0xc], 0x0 */
            ii(0x1011_7fe9, 5);  jmp(0x1011_8062, 0x74); goto l_0x1011_8062;/* jmp 0x10118062 */
        l_0x1011_7fee:
            ii(0x1011_7fee, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_7ff1, 3);  mov(al, memb[ds, eax + 41]);          /* mov al, [eax+0x29] */
            ii(0x1011_7ff4, 2);  xor(ah, ah);                          /* xor ah, ah */
            ii(0x1011_7ff6, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1011_7ff9, 2);  sub(edx, eax);                        /* sub edx, eax */
            ii(0x1011_7ffb, 3);  mov(memd[ss, ebp - 16], edx);         /* mov [ebp-0x10], edx */
            ii(0x1011_7ffe, 4);  movsx(eax, memw[ss, ebp - 16]);       /* movsx eax, word [ebp-0x10] */
            ii(0x1011_8002, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1011_8004, 2);  if(jge(0x1011_800a, 4)) goto l_0x1011_800a;/* jge 0x1011800a */
            ii(0x1011_8006, 4);  add(memd[ss, ebp - 16], 8);           /* add dword [ebp-0x10], 0x8 */
        l_0x1011_800a:
            ii(0x1011_800a, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_800d, 3);  mov(al, memb[ds, eax + 41]);          /* mov al, [eax+0x29] */
            ii(0x1011_8010, 2);  xor(ah, ah);                          /* xor ah, ah */
            ii(0x1011_8012, 3);  sub(eax, memd[ss, ebp - 4]);          /* sub eax, [ebp-0x4] */
            ii(0x1011_8015, 3);  mov(memd[ss, ebp - 20], eax);         /* mov [ebp-0x14], eax */
            ii(0x1011_8018, 4);  movsx(eax, memw[ss, ebp - 20]);       /* movsx eax, word [ebp-0x14] */
            ii(0x1011_801c, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1011_801e, 2);  if(jge(0x1011_8024, 4)) goto l_0x1011_8024;/* jge 0x10118024 */
            ii(0x1011_8020, 4);  add(memd[ss, ebp - 20], 8);           /* add dword [ebp-0x14], 0x8 */
        l_0x1011_8024:
            ii(0x1011_8024, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1011_8027, 4);  cmp(ax, memw[ss, ebp - 20]);          /* cmp ax, [ebp-0x14] */
            ii(0x1011_802b, 2);  if(jge(0x1011_8036, 9)) goto l_0x1011_8036;/* jge 0x10118036 */
            ii(0x1011_802d, 7);  mov(memd[ss, ebp - 24], 1);           /* mov dword [ebp-0x18], 0x1 */
            ii(0x1011_8034, 2);  jmp(0x1011_803d, 7); goto l_0x1011_803d;/* jmp 0x1011803d */
        l_0x1011_8036:
            ii(0x1011_8036, 7);  mov(memd[ss, ebp - 24], 0xffff_ffff); /* mov dword [ebp-0x18], 0xffffffff */
        l_0x1011_803d:
            ii(0x1011_803d, 3);  mov(eax, memd[ss, ebp - 24]);         /* mov eax, [ebp-0x18] */
            ii(0x1011_8040, 3);  mov(memd[ss, ebp - 28], eax);         /* mov [ebp-0x1c], eax */
            ii(0x1011_8043, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_8046, 3);  mov(al, memb[ds, eax + 41]);          /* mov al, [eax+0x29] */
            ii(0x1011_8049, 2);  xor(ah, ah);                          /* xor ah, ah */
            ii(0x1011_804b, 3);  add(eax, memd[ss, ebp - 28]);         /* add eax, [ebp-0x1c] */
            ii(0x1011_804e, 5);  and(eax, 7);                          /* and eax, 0x7 */
            ii(0x1011_8053, 3);  movsx(edx, ax);                       /* movsx edx, ax */
            ii(0x1011_8056, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_8059, 5);  call(0x1014_9fe6, 0x3_1f88);          /* call 0x10149fe6 */
            ii(0x1011_805e, 4);  mov(memb[ss, ebp - 12], 1);           /* mov byte [ebp-0xc], 0x1 */
        l_0x1011_8062:
            ii(0x1011_8062, 3);  mov(al, memb[ss, ebp - 12]);          /* mov al, [ebp-0xc] */
            ii(0x1011_8065, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1011_8067, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1011_8068, 1);  pop(edi);                             /* pop edi */
            ii(0x1011_8069, 1);  pop(esi);                             /* pop esi */
            ii(0x1011_806a, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1011_806b, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1011_806c, 1);  ret();                                /* ret */
        }
    }
}
