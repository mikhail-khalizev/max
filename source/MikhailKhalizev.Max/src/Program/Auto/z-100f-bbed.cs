using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100f_bbed-413eaa44")]
        public void Method_100f_bbed()
        {
            ii(0x100f_bbed, 5); push(0x6c);                             /* push 0x6c */
            ii(0x100f_bbf2, 5); call(Definitions.sys_check_available_stack_size, 0x6_a15b); /* call 0x10165d52 */
            ii(0x100f_bbf7, 1); push(ebx);                              /* push ebx */
            ii(0x100f_bbf8, 1); push(ecx);                              /* push ecx */
            ii(0x100f_bbf9, 1); push(edx);                              /* push edx */
            ii(0x100f_bbfa, 1); push(esi);                              /* push esi */
            ii(0x100f_bbfb, 1); push(edi);                              /* push edi */
            ii(0x100f_bbfc, 1); push(ebp);                              /* push ebp */
            ii(0x100f_bbfd, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100f_bbff, 6); sub(esp, 0x48);                         /* sub esp, 0x48 */
            ii(0x100f_bc05, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100f_bc08, 4); movsx(eax, memw[ss, ebp - 0x4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x100f_bc0c, 3); imul(eax, eax, 0x13);                   /* imul eax, eax, 0x13 */
            ii(0x100f_bc0f, 6); mov(al, memb[ds, eax + 0x101c_35c6]);   /* mov al, [eax+0x101c35c6] */
            ii(0x100f_bc15, 3); mov(memb[ss, ebp - 0x8], al);           /* mov [ebp-0x8], al */
            ii(0x100f_bc18, 4); or(memb[ss, ebp - 0x14], 0x1);          /* or byte [ebp-0x14], 0x1 */
            ii(0x100f_bc1c, 3); lea(eax, ebp - 0x2c);                   /* lea eax, [ebp-0x2c] */
            ii(0x100f_bc1f, 5); call(Definitions.my_ctor_0x101b_38d0, -0x8_53e0); /* call 0x10076844 */
            ii(0x100f_bc24, 3); mov(memd[ss, ebp - 0x30], eax);         /* mov [ebp-0x30], eax */
            ii(0x100f_bc27, 4); and(memb[ss, ebp - 0x14], -0x2 /* 0xfe */); /* and byte [ebp-0x14], 0xfe */
            ii(0x100f_bc2b, 4); mov(memb[ss, ebp - 0xc], 0x1);          /* mov byte [ebp-0xc], 0x1 */
            ii(0x100f_bc2f, 4); cmp(memb[ss, ebp - 0x8], 0x1);          /* cmp byte [ebp-0x8], 0x1 */
            ii(0x100f_bc33, 2); if(jnz(0x100f_bc75, 0x40)) goto l_0x100f_bc75; /* jnz 0x100fbc75 */
            ii(0x100f_bc35, 5); call(0x100c_aa00, -0x3_123a);           /* call 0x100caa00 */
            ii(0x100f_bc3a, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100f_bc3f, 1); push(eax);                              /* push eax */
            ii(0x100f_bc40, 5); call(0x100c_aa20, -0x3_1225);           /* call 0x100caa20 */
            ii(0x100f_bc45, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100f_bc47, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_bc49, 5); mov(esi, StringDefinitions.SelectStartingLocation); /* mov esi, 0x101a28b3 */
            ii(0x100f_bc4e, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x100f_bc50, 2); mov(eax, esi);                          /* mov eax, esi */
            ii(0x100f_bc52, 5); call(0x1011_5d23, 0x1_a0cc);            /* call 0x10115d23 */
            ii(0x100f_bc57, 5); call(0x100d_5470, -0x2_67ec);           /* call 0x100d5470 */
            ii(0x100f_bc5c, 3); movsx(ecx, ax);                         /* movsx ecx, ax */
            ii(0x100f_bc5f, 5); mov(ebx, 0x463);                        /* mov ebx, 0x463 */
            ii(0x100f_bc64, 5); mov(edx, 0x45e);                        /* mov edx, 0x45e */
            ii(0x100f_bc69, 5); mov(eax, 0x101c_7278);                  /* mov eax, 0x101c7278 */
            ii(0x100f_bc6e, 5); call(0x1013_daea, 0x4_1e77);            /* call 0x1013daea */
            ii(0x100f_bc73, 2); if(jmp_func(0x100f_bc79, 0x4)) return;  /* jmp 0x100fbc79 */
        l_0x100f_bc75:
            ii(0x100f_bc75, 4); mov(memb[ss, ebp - 0xc], 0);            /* mov byte [ebp-0xc], 0x0 */
        }
    }
}
