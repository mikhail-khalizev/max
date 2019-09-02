using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100d_bc47-649061dd")]
        public void Method_100d_bc47()
        {
            ii(0x100d_bc47, 5); push(0x24);                             /* push 0x24 */
            ii(0x100d_bc4c, 5); call(Definitions.sys_check_available_stack_size, 0x8_a101); /* call 0x10165d52 */
            ii(0x100d_bc51, 1); push(ebx);                              /* push ebx */
            ii(0x100d_bc52, 1); push(ecx);                              /* push ecx */
            ii(0x100d_bc53, 1); push(esi);                              /* push esi */
            ii(0x100d_bc54, 1); push(edi);                              /* push edi */
            ii(0x100d_bc55, 1); push(ebp);                              /* push ebp */
            ii(0x100d_bc56, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100d_bc58, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100d_bc5e, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100d_bc61, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x100d_bc64, 7); test(memd[ss, ebp - 4], 4);             /* test dword [ebp-0x4], 0x4 */
            ii(0x100d_bc6b, 2); if(jz(0x100d_bc81, 0x14)) goto l_0x100d_bc81; /* jz 0x100dbc81 */
            ii(0x100d_bc6d, 5); mov(edx, 0x101b_5e78);                  /* mov edx, 0x101b5e78 */
            ii(0x100d_bc72, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_bc75, 5); call(Definitions.sys_call_dtor_arr, 0x8_a33e); /* call 0x10165fb8 */
            ii(0x100d_bc7a, 5); call(Definitions.sys_delete_arr, 0x8_a359); /* call 0x10165fd8 */
            ii(0x100d_bc7f, 2); jmp(0x100d_bcdc, 0x5b); goto l_0x100d_bcdc; /* jmp 0x100dbcdc */
        l_0x100d_bc81:
            ii(0x100d_bc81, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_bc84, 7); mov(memd[ds, eax + 0x13], 0x101b_5f2c); /* mov dword [eax+0x13], 0x101b5f2c */
            ii(0x100d_bc8b, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100d_bc90, 5); call(0x1007_6600, -0x6_5695);           /* call 0x10076600 */
            ii(0x100d_bc95, 5); call(0x100f_fa70, 0x2_3dd6);            /* call 0x100ffa70 */
            ii(0x100d_bc9a, 5); mov(eax, 1);                            /* mov eax, 0x1 */
            ii(0x100d_bc9f, 5); call(0x1010_0efe, 0x2_525a);            /* call 0x10100efe */
            ii(0x100d_bca4, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100d_bca6, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_bca9, 5); add(eax, 0x3af);                        /* add eax, 0x3af */
            ii(0x100d_bcae, 5); call(0x1007_5eac, -0x6_5e07);           /* call 0x10075eac */
            ii(0x100d_bcb3, 5); sub(eax, 0x3af);                        /* sub eax, 0x3af */
            ii(0x100d_bcb8, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100d_bcbb, 5); mov(edx, 1);                            /* mov edx, 0x1 */
            ii(0x100d_bcc0, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_bcc3, 5); call(0x100d_9a4a, -0x227e);             /* call 0x100d9a4a */
            ii(0x100d_bcc8, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100d_bccb, 7); test(memd[ss, ebp - 4], 2);             /* test dword [ebp-0x4], 0x2 */
            ii(0x100d_bcd2, 2); if(jz(0x100d_bcdc, 8)) goto l_0x100d_bcdc; /* jz 0x100dbcdc */
            ii(0x100d_bcd4, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_bcd7, 5); call(Definitions.sys_delete, 0x8_a288); /* call 0x10165f64 */
        l_0x100d_bcdc:
            ii(0x100d_bcdc, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_bcdf, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x100d_bce2, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100d_bce5, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100d_bce7, 1); pop(ebp);                               /* pop ebp */
            ii(0x100d_bce8, 1); pop(edi);                               /* pop edi */
            ii(0x100d_bce9, 1); pop(esi);                               /* pop esi */
            ii(0x100d_bcea, 1); pop(ecx);                               /* pop ecx */
            ii(0x100d_bceb, 1); pop(ebx);                               /* pop ebx */
            ii(0x100d_bcec, 1); ret();                                  /* ret */
        }
    }
}
