using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_825f-714408cb")]
        public void Method_100c_825f()
        {
            ii(0x100c_825f, 5);  push(0x2c);                           /* push 0x2c */
            ii(0x100c_8264, 5);  call(Definitions.sys_check_available_stack_size, 0x9_dae9);/* call 0x10165d52 */
            ii(0x100c_8269, 1);  push(ebx);                            /* push ebx */
            ii(0x100c_826a, 1);  push(ecx);                            /* push ecx */
            ii(0x100c_826b, 1);  push(esi);                            /* push esi */
            ii(0x100c_826c, 1);  push(edi);                            /* push edi */
            ii(0x100c_826d, 1);  push(ebp);                            /* push ebp */
            ii(0x100c_826e, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100c_8270, 6);  sub(esp, 0x14);                       /* sub esp, 0x14 */
            ii(0x100c_8276, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100c_8279, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x100c_827c, 7);  test(memd[ss, ebp - 4], 4);           /* test dword [ebp-0x4], 0x4 */
            ii(0x100c_8283, 2);  if(jz(0x100c_829c, 0x17)) goto l_0x100c_829c;/* jz 0x100c829c */
            ii(0x100c_8285, 5);  mov(edx, 0x101b_56c0);                /* mov edx, 0x101b56c0 */
            ii(0x100c_828a, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_828d, 5);  call(Definitions.sys_call_dtor_arr, 0x9_dd26);/* call 0x10165fb8 */
            ii(0x100c_8292, 5);  call(Definitions.sys_delete_arr, 0x9_dd41);/* call 0x10165fd8 */
            ii(0x100c_8297, 5);  jmp(0x100c_8358, 0xbc); goto l_0x100c_8358;/* jmp 0x100c8358 */
        l_0x100c_829c:
            ii(0x100c_829c, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_829f, 7);  mov(memd[ds, eax + 2], 0x101b_58e8);  /* mov dword [eax+0x2], 0x101b58e8 */
            ii(0x100c_82a6, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_82a9, 4);  cmp(memb[ds, eax + 35], 0);           /* cmp byte [eax+0x23], 0x0 */
            ii(0x100c_82ad, 6);  if(jz(0x100c_8337, 0x84)) goto l_0x100c_8337;/* jz 0x100c8337 */
            ii(0x100c_82b3, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_82b6, 4);  mov(ax, memw[ds, eax + 11]);          /* mov ax, [eax+0xb] */
            ii(0x100c_82ba, 3);  mov(memd[ss, ebp - 20], eax);         /* mov [ebp-0x14], eax */
            ii(0x100c_82bd, 2);  jmp(0x100c_82c5, 6); goto l_0x100c_82c5;/* jmp 0x100c82c5 */
        l_0x100c_82bf:
            ii(0x100c_82bf, 3);  mov(eax, memd[ss, ebp - 20]);         /* mov eax, [ebp-0x14] */
            ii(0x100c_82c2, 3);  inc(memd[ss, ebp - 20]);              /* inc dword [ebp-0x14] */
        l_0x100c_82c5:
            ii(0x100c_82c5, 4);  movsx(edx, memw[ss, ebp - 20]);       /* movsx edx, word [ebp-0x14] */
            ii(0x100c_82c9, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_82cc, 3);  cmp(edx, memd[ds, eax + 19]);         /* cmp edx, [eax+0x13] */
            ii(0x100c_82cf, 2);  if(jge(0x100c_8337, 0x66)) goto l_0x100c_8337;/* jge 0x100c8337 */
            ii(0x100c_82d1, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_82d4, 4);  mov(ax, memw[ds, eax + 15]);          /* mov ax, [eax+0xf] */
            ii(0x100c_82d8, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x100c_82db, 2);  jmp(0x100c_82e3, 6); goto l_0x100c_82e3;/* jmp 0x100c82e3 */
        l_0x100c_82dd:
            ii(0x100c_82dd, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100c_82e0, 3);  inc(memd[ss, ebp - 16]);              /* inc dword [ebp-0x10] */
        l_0x100c_82e3:
            ii(0x100c_82e3, 4);  movsx(edx, memw[ss, ebp - 16]);       /* movsx edx, word [ebp-0x10] */
            ii(0x100c_82e7, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_82ea, 3);  cmp(edx, memd[ds, eax + 23]);         /* cmp edx, [eax+0x17] */
            ii(0x100c_82ed, 2);  if(jge(0x100c_8335, 0x46)) goto l_0x100c_8335;/* jge 0x100c8335 */
            ii(0x100c_82ef, 4);  movsx(eax, memw[ss, ebp - 20]);       /* movsx eax, word [ebp-0x14] */
            ii(0x100c_82f3, 3);  shl(eax, 2);                          /* shl eax, 0x2 */
            ii(0x100c_82f6, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x100c_82f8, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_82fb, 3);  mov(eax, memd[ds, eax + 31]);         /* mov eax, [eax+0x1f] */
            ii(0x100c_82fe, 2);  add(eax, edx);                        /* add eax, edx */
            ii(0x100c_8300, 4);  movsx(edx, memw[ss, ebp - 16]);       /* movsx edx, word [ebp-0x10] */
            ii(0x100c_8304, 2);  mov(eax, memd[ds, eax]);              /* mov eax, [eax] */
            ii(0x100c_8306, 2);  add(eax, edx);                        /* add eax, edx */
            ii(0x100c_8308, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100c_830a, 2);  mov(dl, memb[ds, eax]);               /* mov dl, [eax] */
            ii(0x100c_830c, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_830f, 3);  mov(eax, memd[ds, eax + 5]);          /* mov eax, [eax+0x5] */
            ii(0x100c_8312, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x100c_8315, 2);  cmp(edx, eax);                        /* cmp edx, eax */
            ii(0x100c_8317, 2);  if(jnz(0x100c_8333, 0x1a)) goto l_0x100c_8333;/* jnz 0x100c8333 */
            ii(0x100c_8319, 4);  movsx(edx, memw[ss, ebp - 20]);       /* movsx edx, word [ebp-0x14] */
            ii(0x100c_831d, 3);  shl(edx, 2);                          /* shl edx, 0x2 */
            ii(0x100c_8320, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_8323, 3);  mov(eax, memd[ds, eax + 31]);         /* mov eax, [eax+0x1f] */
            ii(0x100c_8326, 2);  add(eax, edx);                        /* add eax, edx */
            ii(0x100c_8328, 4);  movsx(edx, memw[ss, ebp - 16]);       /* movsx edx, word [ebp-0x10] */
            ii(0x100c_832c, 2);  mov(eax, memd[ds, eax]);              /* mov eax, [eax] */
            ii(0x100c_832e, 2);  add(eax, edx);                        /* add eax, edx */
            ii(0x100c_8330, 3);  mov(memb[ds, eax], 0);                /* mov byte [eax], 0x0 */
        l_0x100c_8333:
            ii(0x100c_8333, 2);  jmp(0x100c_82dd, -0x58); goto l_0x100c_82dd;/* jmp 0x100c82dd */
        l_0x100c_8335:
            ii(0x100c_8335, 2);  jmp(0x100c_82bf, -0x78); goto l_0x100c_82bf;/* jmp 0x100c82bf */
        l_0x100c_8337:
            ii(0x100c_8337, 5);  mov(edx, 1);                          /* mov edx, 0x1 */
            ii(0x100c_833c, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_833f, 5);  call(0x1013_ab27, 0x7_27e3);          /* call 0x1013ab27 */
            ii(0x100c_8344, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100c_8347, 7);  test(memd[ss, ebp - 4], 2);           /* test dword [ebp-0x4], 0x2 */
            ii(0x100c_834e, 2);  if(jz(0x100c_8358, 8)) goto l_0x100c_8358;/* jz 0x100c8358 */
            ii(0x100c_8350, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_8353, 5);  call(Definitions.sys_delete, 0x9_dc0c);/* call 0x10165f64 */
        l_0x100c_8358:
            ii(0x100c_8358, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_835b, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x100c_835e, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100c_8361, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100c_8363, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100c_8364, 1);  pop(edi);                             /* pop edi */
            ii(0x100c_8365, 1);  pop(esi);                             /* pop esi */
            ii(0x100c_8366, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100c_8367, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100c_8368, 1);  ret();                                /* ret */
        }
    }
}
