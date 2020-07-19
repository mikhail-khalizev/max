using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_ee7d-c451d920")]
        public void Method_1007_ee7d()
        {
            ii(0x1007_ee7d, 5);  push(0x34);                           /* push 0x34 */
            ii(0x1007_ee82, 5);  call(Definitions.sys_check_available_stack_size, 0xe_6ecb);/* call 0x10165d52 */
            ii(0x1007_ee87, 1);  push(ebx);                            /* push ebx */
            ii(0x1007_ee88, 1);  push(ecx);                            /* push ecx */
            ii(0x1007_ee89, 1);  push(esi);                            /* push esi */
            ii(0x1007_ee8a, 1);  push(edi);                            /* push edi */
            ii(0x1007_ee8b, 1);  push(ebp);                            /* push ebp */
            ii(0x1007_ee8c, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1007_ee8e, 6);  sub(esp, 0x1c);                       /* sub esp, 0x1c */
            ii(0x1007_ee94, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1007_ee97, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1007_ee9a, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_ee9d, 5);  call(0x1015_26ac, 0xd_380a);          /* call 0x101526ac */
            ii(0x1007_eea2, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1007_eea4, 2);  if(jnz(0x1007_eeaf, 9)) goto l_0x1007_eeaf;/* jnz 0x1007eeaf */
            ii(0x1007_eea6, 7);  mov(memd[ss, ebp - 12], 0x2900);      /* mov dword [ebp-0xc], 0x2900 */
            ii(0x1007_eead, 2);  jmp(0x1007_eeca, 0x1b); goto l_0x1007_eeca;/* jmp 0x1007eeca */
        l_0x1007_eeaf:
            ii(0x1007_eeaf, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_eeb2, 5);  call(0x1015_26ac, 0xd_37f5);          /* call 0x101526ac */
            ii(0x1007_eeb7, 3);  mov(memd[ss, ebp - 20], eax);         /* mov [ebp-0x14], eax */
            ii(0x1007_eeba, 3);  mov(eax, memd[ss, ebp - 20]);         /* mov eax, [ebp-0x14] */
            ii(0x1007_eebd, 3);  mov(edx, memd[ds, eax + 2]);          /* mov edx, [eax+0x2] */
            ii(0x1007_eec0, 3);  mov(eax, memd[ss, ebp - 20]);         /* mov eax, [ebp-0x14] */
            ii(0x1007_eec3, 3);  call_abs(memd[ds, edx + 20]);         /* call dword [edx+0x14] */
            ii(0x1007_eec6, 1);  cwde();                               /* cwde */
            ii(0x1007_eec7, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
        l_0x1007_eeca:
            ii(0x1007_eeca, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1007_eecd, 3);  movsx(ecx, ax);                       /* movsx ecx, ax */
            ii(0x1007_eed0, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_eed3, 5);  call(0x1015_26ac, 0xd_37d4);          /* call 0x101526ac */
            ii(0x1007_eed8, 2);  mov(ebx, eax);                        /* mov ebx, eax */
            ii(0x1007_eeda, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_eedd, 3);  mov(al, memb[ds, eax + 38]);          /* mov al, [eax+0x26] */
            ii(0x1007_eee0, 2);  xor(ah, ah);                          /* xor ah, ah */
            ii(0x1007_eee2, 3);  movsx(edx, ax);                       /* movsx edx, ax */
            ii(0x1007_eee5, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1007_eee8, 5);  call(0x100a_26d1, 0x2_37e4);          /* call 0x100a26d1 */
            ii(0x1007_eeed, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1007_eef0, 3);  lea(eax, memd[ss, ebp - 8]);          /* lea eax, [ebp-0x8] */
            ii(0x1007_eef3, 3);  mov(memd[ss, ebp - 24], eax);         /* mov [ebp-0x18], eax */
            ii(0x1007_eef6, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1007_eef9, 3);  add(eax, 0x13);                       /* add eax, 0x13 */
            ii(0x1007_eefc, 5);  call(Definitions.my_ctor_0x101b_38f8, -0x8811);/* call 0x100766f0 */
            ii(0x1007_ef01, 3);  sub(eax, 0x13);                       /* sub eax, 0x13 */
            ii(0x1007_ef04, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1007_ef07, 3);  lea(eax, memd[ss, ebp - 8]);          /* lea eax, [ebp-0x8] */
            ii(0x1007_ef0a, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x1007_ef0d, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1007_ef10, 7);  mov(memd[ds, eax + 2], 0x101b_3db0);  /* mov dword [eax+0x2], 0x101b3db0 */
            ii(0x1007_ef17, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1007_ef1a, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1007_ef1d, 3);  add(eax, 0x13);                       /* add eax, 0x13 */
            ii(0x1007_ef20, 5);  call(0x1007_6630, -0x88f5);           /* call 0x10076630 */
            ii(0x1007_ef25, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1007_ef28, 3);  mov(memd[ss, ebp - 28], eax);         /* mov [ebp-0x1c], eax */
            ii(0x1007_ef2b, 3);  mov(eax, memd[ss, ebp - 28]);         /* mov eax, [ebp-0x1c] */
            ii(0x1007_ef2e, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1007_ef30, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1007_ef31, 1);  pop(edi);                             /* pop edi */
            ii(0x1007_ef32, 1);  pop(esi);                             /* pop esi */
            ii(0x1007_ef33, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1007_ef34, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1007_ef35, 1);  ret();                                /* ret */
        }
    }
}
