using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100d_00b2-7685e02a")]
        public void Method_100d_00b2()
        {
            ii(0x100d_00b2, 5); push(0x24);                             /* push 0x24 */
            ii(0x100d_00b7, 5); call(Definitions.sys_check_available_stack_size, 0x9_5c96); /* call 0x10165d52 */
            ii(0x100d_00bc, 1); push(ebx);                              /* push ebx */
            ii(0x100d_00bd, 1); push(ecx);                              /* push ecx */
            ii(0x100d_00be, 1); push(esi);                              /* push esi */
            ii(0x100d_00bf, 1); push(edi);                              /* push edi */
            ii(0x100d_00c0, 1); push(ebp);                              /* push ebp */
            ii(0x100d_00c1, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100d_00c3, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100d_00c9, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100d_00cc, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x100d_00cf, 7); test(memd[ss, ebp - 4], 4);             /* test dword [ebp-0x4], 0x4 */
            ii(0x100d_00d6, 2); if(jz(0x100d_00ec, 0x14)) goto l_0x100d_00ec; /* jz 0x100d00ec */
            ii(0x100d_00d8, 5); mov(edx, 0x101b_5c38);                  /* mov edx, 0x101b5c38 */
            ii(0x100d_00dd, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_00e0, 5); call(Definitions.sys_call_dtor_arr, 0x9_5ed3); /* call 0x10165fb8 */
            ii(0x100d_00e5, 5); call(Definitions.sys_delete_arr, 0x9_5eee); /* call 0x10165fd8 */
            ii(0x100d_00ea, 2); jmp(0x100d_0138, 0x4c); goto l_0x100d_0138; /* jmp 0x100d0138 */
        l_0x100d_00ec:
            ii(0x100d_00ec, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_00ef, 7); mov(memd[ds, eax + 64], 0x101b_5cbc);   /* mov dword [eax+0x40], 0x101b5cbc */
            ii(0x100d_00f6, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_00f9, 3); mov(eax, memd[ds, eax + 42]);           /* mov eax, [eax+0x2a] */
            ii(0x100d_00fc, 5); call(Definitions.sys_free, 0x9_afc0);   /* call 0x1016b0c1 */
            ii(0x100d_0101, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100d_0103, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_0106, 3); add(eax, 0x30);                         /* add eax, 0x30 */
            ii(0x100d_0109, 5); call(0x100e_957e, 0x1_9470);            /* call 0x100e957e */
            ii(0x100d_010e, 3); sub(eax, 0x30);                         /* sub eax, 0x30 */
            ii(0x100d_0111, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100d_0114, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100d_0116, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_0119, 3); add(eax, 0x1e);                         /* add eax, 0x1e */
            ii(0x100d_011c, 5); call(0x1008_8b04, -0x4_761d);           /* call 0x10088b04 */
            ii(0x100d_0121, 3); sub(eax, 0x1e);                         /* sub eax, 0x1e */
            ii(0x100d_0124, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100d_0127, 7); test(memd[ss, ebp - 4], 2);             /* test dword [ebp-0x4], 0x2 */
            ii(0x100d_012e, 2); if(jz(0x100d_0138, 8)) goto l_0x100d_0138; /* jz 0x100d0138 */
            ii(0x100d_0130, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_0133, 5); call(Definitions.sys_delete, 0x9_5e2c); /* call 0x10165f64 */
        l_0x100d_0138:
            ii(0x100d_0138, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_013b, 3); mov(memd[ss, ebp - 12], eax);           /* mov [ebp-0xc], eax */
            ii(0x100d_013e, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x100d_0141, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100d_0143, 1); pop(ebp);                               /* pop ebp */
            ii(0x100d_0144, 1); pop(edi);                               /* pop edi */
            ii(0x100d_0145, 1); pop(esi);                               /* pop esi */
            ii(0x100d_0146, 1); pop(ecx);                               /* pop ecx */
            ii(0x100d_0147, 1); pop(ebx);                               /* pop ebx */
            ii(0x100d_0148, 1); ret();                                  /* ret */
        }
    }
}
