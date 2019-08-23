using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_fa7c-786159f4")]
        public void Method_100c_fa7c()
        {
            ii(0x100c_fa7c, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100c_fa81, 5); calld(Definitions.sys_check_available_stack_size, 0x9_62cc); /* call 0x10165d52 */
            ii(0x100c_fa86, 1); pushd(ecx);                             /* push ecx */
            ii(0x100c_fa87, 1); pushd(esi);                             /* push esi */
            ii(0x100c_fa88, 1); pushd(edi);                             /* push edi */
            ii(0x100c_fa89, 1); pushd(ebp);                             /* push ebp */
            ii(0x100c_fa8a, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_fa8c, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100c_fa92, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100c_fa95, 3); mov(memb_a32[ss, ebp - 0x8], dl);       /* mov [ebp-0x8], dl */
            ii(0x100c_fa98, 3); mov(memb_a32[ss, ebp - 0x4], bl);       /* mov [ebp-0x4], bl */
            ii(0x100c_fa9b, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100c_fa9d, 3); mov(al, memb_a32[ss, ebp - 0x8]);       /* mov al, [ebp-0x8] */
            ii(0x100c_faa0, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100c_faa2, 2); if(jnzd(0x100c_fab7, 0x13)) goto l_0x100c_fab7; /* jnz 0x100cfab7 */
            ii(0x100c_faa4, 5); calld(0x100d_51c4, 0x571b);             /* call 0x100d51c4 */
            ii(0x100c_faa9, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100c_faab, 2); mov(dl, al);                            /* mov dl, al */
            ii(0x100c_faad, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100c_fab0, 5); calld(0x100c_fb06, 0x51);               /* call 0x100cfb06 */
            ii(0x100c_fab5, 2); jmpd(0x100c_faff, 0x48); goto l_0x100c_faff; /* jmp 0x100cfaff */
        l_0x100c_fab7:
            ii(0x100c_fab7, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100c_faba, 4); cmp(memb_a32[ds, eax + 0x28], 0);       /* cmp byte [eax+0x28], 0x0 */
            ii(0x100c_fabe, 2); if(jnzd(0x100c_faff, 0x3f)) goto l_0x100c_faff; /* jnz 0x100cfaff */
            ii(0x100c_fac0, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100c_fac3, 3); cmp(memd_a32[ds, eax], 0);              /* cmp dword [eax], 0x0 */
            ii(0x100c_fac6, 2); if(jzd(0x100c_faf8, 0x30)) goto l_0x100c_faf8; /* jz 0x100cfaf8 */
            ii(0x100c_fac8, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100c_facb, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x100c_facd, 5); calld(Definitions.sys_display_draw_3, 0x9_9d42); /* call 0x10169814 */
            ii(0x100c_fad2, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100c_fad4, 3); mov(al, memb_a32[ss, ebp - 0x4]);       /* mov al, [ebp-0x4] */
            ii(0x100c_fad7, 1); pushd(eax);                             /* push eax */
            ii(0x100c_fad8, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x100c_fada, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100c_fadd, 5); calld(0x100c_e850, -0x1292);            /* call 0x100ce850 */
            ii(0x100c_fae2, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x100c_fae4, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100c_fae7, 5); calld(0x100c_e809, -0x12e3);            /* call 0x100ce809 */
            ii(0x100c_faec, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100c_faee, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100c_faf1, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x100c_faf3, 5); calld(Definitions.sys_display_draw_2, 0x9_8ff8); /* call 0x10168af0 */
        l_0x100c_faf8:
            ii(0x100c_faf8, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100c_fafb, 4); mov(memb_a32[ds, eax + 0x28], 0x1);     /* mov byte [eax+0x28], 0x1 */
        l_0x100c_faff:
            ii(0x100c_faff, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_fb01, 1); popd(ebp);                              /* pop ebp */
            ii(0x100c_fb02, 1); popd(edi);                              /* pop edi */
            ii(0x100c_fb03, 1); popd(esi);                              /* pop esi */
            ii(0x100c_fb04, 1); popd(ecx);                              /* pop ecx */
            ii(0x100c_fb05, 1); retd();                                 /* ret */
        }
    }
}
