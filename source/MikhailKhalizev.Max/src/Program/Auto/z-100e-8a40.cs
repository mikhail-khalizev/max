using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("1b2f4dcf-37ec-4256-b387-f04c7e47ac00")]
        public void Method_100e_8a40()
        {
            ii(0x100e_8a40, 5); pushd(0x2c);                            /* push 0x2c */
            ii(0x100e_8a45, 5); calld(Definitions.sys_check_available_stack_size, 0x7d308); /* call 0x10165d52 */
            ii(0x100e_8a4a, 1); pushd(ebx);                             /* push ebx */
            ii(0x100e_8a4b, 1); pushd(ecx);                             /* push ecx */
            ii(0x100e_8a4c, 1); pushd(edx);                             /* push edx */
            ii(0x100e_8a4d, 1); pushd(esi);                             /* push esi */
            ii(0x100e_8a4e, 1); pushd(edi);                             /* push edi */
            ii(0x100e_8a4f, 1); pushd(ebp);                             /* push ebp */
            ii(0x100e_8a50, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_8a52, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x100e_8a58, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100e_8a5b, 5); calld(0x100e_88bd, -0x1a3);             /* call 0x100e88bd */
            ii(0x100e_8a60, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_8a63, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100e_8a66, 5); calld(/* sys */ 0x1016_cc1c, 0x841b1);  /* call 0x1016cc1c */
            ii(0x100e_8a6b, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100e_8a6e, 7); mov(memd_a32[ss, ebp - 0x8], 0);        /* mov dword [ebp-0x8], 0x0 */
            ii(0x100e_8a75, 2); jmpd(0x100e_8a7d, 0x6); goto l_0x100e_8a7d; /* jmp 0x100e8a7d */
        l_0x100e_8a77:
            ii(0x100e_8a77, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_8a7a, 3); inc(memd_a32[ss, ebp - 0x8]);           /* inc dword [ebp-0x8] */
        l_0x100e_8a7d:
            ii(0x100e_8a7d, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x100e_8a81, 5); cmp(eax, 0x300);                        /* cmp eax, 0x300 */
            ii(0x100e_8a86, 2); if(jged(0x100e_8aa7, 0x1f)) goto l_0x100e_8aa7; /* jge 0x100e8aa7 */
            ii(0x100e_8a88, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x100e_8a8c, 3); add(eax, memd_a32[ss, ebp - 0x10]);     /* add eax, [ebp-0x10] */
            ii(0x100e_8a8f, 3); mov(al, memb_a32[ds, eax + 0x8]);       /* mov al, [eax+0x8] */
            ii(0x100e_8a92, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100e_8a97, 3); sar(eax, 0x2);                          /* sar eax, 0x2 */
            ii(0x100e_8a9a, 2); mov(dl, al);                            /* mov dl, al */
            ii(0x100e_8a9c, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x100e_8aa0, 3); add(eax, memd_a32[ss, ebp - 0xc]);      /* add eax, [ebp-0xc] */
            ii(0x100e_8aa3, 2); mov(memb_a32[ds, eax], dl);             /* mov [eax], dl */
            ii(0x100e_8aa5, 2); jmpd(0x100e_8a77, -0x30); goto l_0x100e_8a77; /* jmp 0x100e8a77 */
        l_0x100e_8aa7:
            ii(0x100e_8aa7, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100e_8aaa, 5); calld(Definitions.sys_display_apply_palette, 0x8410d); /* call 0x1016cbbc */
            ii(0x100e_8aaf, 10); mov(memd_a32[ds, Definitions.ptr_to_pallete], 0x101b_dec0); /* mov dword [0x101c9464], 0x101bdec0 */
            ii(0x100e_8ab9, 5); mov(ebx, 0x300);                        /* mov ebx, 0x300 */
            ii(0x100e_8abe, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x100e_8ac1, 5); mov(eax, memd_a32[ds, Definitions.ptr_to_pallete]); /* mov eax, [0x101c9464] */
            ii(0x100e_8ac6, 5); calld(Definitions.sys_memcpy, 0x7d380); /* call 0x10165e4b */
            ii(0x100e_8acb, 5); mov(eax, memd_a32[ds, Definitions.ptr_to_pallete]); /* mov eax, [0x101c9464] */
            ii(0x100e_8ad0, 5); calld(/* sys */ 0x1016_d2cc, 0x847f7);  /* call 0x1016d2cc */
            ii(0x100e_8ad5, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_8ad7, 1); popd(ebp);                              /* pop ebp */
            ii(0x100e_8ad8, 1); popd(edi);                              /* pop edi */
            ii(0x100e_8ad9, 1); popd(esi);                              /* pop esi */
            ii(0x100e_8ada, 1); popd(edx);                              /* pop edx */
            ii(0x100e_8adb, 1); popd(ecx);                              /* pop ecx */
            ii(0x100e_8adc, 1); popd(ebx);                              /* pop ebx */
            ii(0x100e_8add, 1); retd(); return;                         /* ret */
        }
    }
}