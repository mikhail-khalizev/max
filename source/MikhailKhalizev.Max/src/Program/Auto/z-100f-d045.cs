using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("36215151-848c-4f58-bfcc-6ada01f6427a")]
        public void Method_100f_d045()
        {
            ii(0x100f_d045, 5); pushd(0x78);                            /* push 0x78 */
            ii(0x100f_d04a, 5); calld(Definitions.sys_check_available_stack_size, 0x68d03); /* call 0x10165d52 */
            ii(0x100f_d04f, 1); pushd(ebx);                             /* push ebx */
            ii(0x100f_d050, 1); pushd(ecx);                             /* push ecx */
            ii(0x100f_d051, 1); pushd(edx);                             /* push edx */
            ii(0x100f_d052, 1); pushd(esi);                             /* push esi */
            ii(0x100f_d053, 1); pushd(edi);                             /* push edi */
            ii(0x100f_d054, 1); pushd(ebp);                             /* push ebp */
            ii(0x100f_d055, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100f_d057, 6); sub(esp, 0x5c);                         /* sub esp, 0x5c */
            ii(0x100f_d05d, 5); mov(edx, 0x80);                         /* mov edx, 0x80 */
            ii(0x100f_d062, 3); lea(eax, ebp - 0x50);                   /* lea eax, [ebp-0x50] */
            ii(0x100f_d065, 5); calld(0x100f_c3b0, -0xcba);             /* call 0x100fc3b0 */
            ii(0x100f_d06a, 5); mov(edx, 0x20);                         /* mov edx, 0x20 */
            ii(0x100f_d06f, 3); lea(eax, ebp - 0x38);                   /* lea eax, [ebp-0x38] */
            ii(0x100f_d072, 5); calld(0x100f_c3b0, -0xcc7);             /* call 0x100fc3b0 */
            ii(0x100f_d077, 5); mov(edx, 0x40);                         /* mov edx, 0x40 */
            ii(0x100f_d07c, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x100f_d07f, 5); calld(0x100f_c3b0, -0xcd4);             /* call 0x100fc3b0 */
            ii(0x100f_d084, 5); mov(eax, 0x1d);                         /* mov eax, 0x1d */
            ii(0x100f_d089, 5); calld(0x1007_5fdc, -0x870b2);           /* call 0x10075fdc */
            ii(0x100f_d08e, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100f_d091, 5); mov(eax, memd_a32[ds, 0x101c_5628]);    /* mov eax, [0x101c5628] */
            ii(0x100f_d096, 5); calld(/* sys */ 0x1016_5ebf, 0x68e24);  /* call 0x10165ebf */
            ii(0x100f_d09b, 3); lea(eax, ebp - 0x50);                   /* lea eax, [ebp-0x50] */
            ii(0x100f_d09e, 5); calld(0x100f_ca4f, -0x654);             /* call 0x100fca4f */
            ii(0x100f_d0a3, 3); lea(eax, ebp - 0x38);                   /* lea eax, [ebp-0x38] */
            ii(0x100f_d0a6, 5); calld(0x100f_ca4f, -0x65c);             /* call 0x100fca4f */
            ii(0x100f_d0ab, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x100f_d0ae, 5); calld(0x100f_ca4f, -0x664);             /* call 0x100fca4f */
            ii(0x100f_d0b3, 7); mov(memd_a32[ss, ebp - 0x4], 0);        /* mov dword [ebp-0x4], 0x0 */
            ii(0x100f_d0ba, 2); jmpd(0x100f_d0c2, 0x6); goto l_0x100f_d0c2; /* jmp 0x100fd0c2 */
        l_0x100f_d0bc:
            ii(0x100f_d0bc, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100f_d0bf, 3); inc(memd_a32[ss, ebp - 0x4]);           /* inc dword [ebp-0x4] */
        l_0x100f_d0c2:
            ii(0x100f_d0c2, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x100f_d0c6, 3); cmp(eax, 0x4);                          /* cmp eax, 0x4 */
            ii(0x100f_d0c9, 6); if(jged(0x100f_d190, 0xc1)) goto l_0x100f_d190; /* jge 0x100fd190 */
            ii(0x100f_d0cf, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x100f_d0d3, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x100f_d0d9, 6); mov(al, memb_a32[ds, eax + 0x101c_a490]); /* mov al, [eax+0x101ca490] */
            ii(0x100f_d0df, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100f_d0e4, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100f_d0e6, 6); if(jzd(0x100f_d18b, 0x9f)) goto l_0x100f_d18b; /* jz 0x100fd18b */
            ii(0x100f_d0ec, 3); lea(eax, ebp - 0x54);                   /* lea eax, [ebp-0x54] */
            ii(0x100f_d0ef, 5); calld(Definitions.my_ctor_0x101b4184, -0x86604); /* call 0x10076af0 */
            ii(0x100f_d0f4, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x100f_d0f8, 3); imul(eax, eax, 0x13);                   /* imul eax, eax, 0x13 */
            ii(0x100f_d0fb, 7); mov(ax, memw_a32[ds, eax + 0x101c_35bc]); /* mov ax, [eax+0x101c35bc] */
            ii(0x100f_d102, 4); mov(memw_a32[ss, ebp - 0x54], ax);      /* mov [ebp-0x54], ax */
            ii(0x100f_d106, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x100f_d10a, 3); imul(eax, eax, 0x13);                   /* imul eax, eax, 0x13 */
            ii(0x100f_d10d, 7); mov(ax, memw_a32[ds, eax + 0x101c_35be]); /* mov ax, [eax+0x101c35be] */
            ii(0x100f_d114, 4); mov(memw_a32[ss, ebp - 0x52], ax);      /* mov [ebp-0x52], ax */
            ii(0x100f_d118, 3); lea(edx, ebp - 0x52);                   /* lea edx, [ebp-0x52] */
            ii(0x100f_d11b, 3); lea(eax, ebp - 0x54);                   /* lea eax, [ebp-0x54] */
            ii(0x100f_d11e, 5); calld(0x100f_cd9c, -0x387);             /* call 0x100fcd9c */
            ii(0x100f_d123, 5); mov(ecx, 0x64);                         /* mov ecx, 0x64 */
            ii(0x100f_d128, 4); movsx(edx, memw_a32[ss, ebp - 0x8]);    /* movsx edx, word [ebp-0x8] */
            ii(0x100f_d12c, 3); imul(edx, edx, 0xc);                    /* imul edx, edx, 0xc */
            ii(0x100f_d12f, 3); add(edx, 0xa);                          /* add edx, 0xa */
            ii(0x100f_d132, 5); mov(ebx, 0x14);                         /* mov ebx, 0x14 */
            ii(0x100f_d137, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x100f_d139, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x100f_d13c, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x100f_d13e, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x100f_d141, 3); lea(edx, ebp - 0x54);                   /* lea edx, [ebp-0x54] */
            ii(0x100f_d144, 3); lea(eax, ebp - 0x58);                   /* lea eax, [ebp-0x58] */
            ii(0x100f_d147, 5); calld(0x1007_5e64, -0x872e8);           /* call 0x10075e64 */
            ii(0x100f_d14c, 3); lea(esi, ebp - 0x50);                   /* lea esi, [ebp-0x50] */
            ii(0x100f_d14f, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100f_d151, 2); mov(eax, esi);                          /* mov eax, esi */
            ii(0x100f_d153, 5); calld(0x100f_c6f6, -0xa62);             /* call 0x100fc6f6 */
            ii(0x100f_d158, 5); mov(ecx, 0x64);                         /* mov ecx, 0x64 */
            ii(0x100f_d15d, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x100f_d161, 3); shl(eax, 0x3);                          /* shl eax, 0x3 */
            ii(0x100f_d164, 3); lea(edx, eax + 0xa);                    /* lea edx, [eax+0xa] */
            ii(0x100f_d167, 5); mov(ebx, 0x14);                         /* mov ebx, 0x14 */
            ii(0x100f_d16c, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x100f_d16e, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x100f_d171, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x100f_d173, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x100f_d176, 3); lea(edx, ebp - 0x54);                   /* lea edx, [ebp-0x54] */
            ii(0x100f_d179, 3); lea(eax, ebp - 0x5c);                   /* lea eax, [ebp-0x5c] */
            ii(0x100f_d17c, 5); calld(0x1007_5e64, -0x8731d);           /* call 0x10075e64 */
            ii(0x100f_d181, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100f_d183, 3); lea(eax, ebp - 0x38);                   /* lea eax, [ebp-0x38] */
            ii(0x100f_d186, 5); calld(0x100f_c6f6, -0xa95);             /* call 0x100fc6f6 */
        l_0x100f_d18b:
            ii(0x100f_d18b, 5); jmpd(0x100f_d0bc, -0xd4); goto l_0x100f_d0bc; /* jmp 0x100fd0bc */
        l_0x100f_d190:
            ii(0x100f_d190, 3); lea(edx, ebp - 0x38);                   /* lea edx, [ebp-0x38] */
            ii(0x100f_d193, 3); lea(eax, ebp - 0x50);                   /* lea eax, [ebp-0x50] */
            ii(0x100f_d196, 5); calld(0x100f_ce65, -0x336);             /* call 0x100fce65 */
            ii(0x100f_d19b, 3); lea(eax, ebp - 0x50);                   /* lea eax, [ebp-0x50] */
            ii(0x100f_d19e, 5); calld(0x100f_cae7, -0x6bc);             /* call 0x100fcae7 */
            ii(0x100f_d1a3, 3); lea(eax, ebp - 0x38);                   /* lea eax, [ebp-0x38] */
            ii(0x100f_d1a6, 5); calld(0x100f_cae7, -0x6c4);             /* call 0x100fcae7 */
            ii(0x100f_d1ab, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x100f_d1ae, 5); calld(0x100f_cae7, -0x6cc);             /* call 0x100fcae7 */
            ii(0x100f_d1b3, 5); mov(eax, 0x1c);                         /* mov eax, 0x1c */
            ii(0x100f_d1b8, 5); calld(0x1007_5fdc, -0x871e1);           /* call 0x10075fdc */
            ii(0x100f_d1bd, 1); cwde();                                 /* cwde */
            ii(0x100f_d1be, 5); calld(0x100f_ccb1, -0x512);             /* call 0x100fccb1 */
            ii(0x100f_d1c3, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100f_d1c5, 1); popd(ebp);                              /* pop ebp */
            ii(0x100f_d1c6, 1); popd(edi);                              /* pop edi */
            ii(0x100f_d1c7, 1); popd(esi);                              /* pop esi */
            ii(0x100f_d1c8, 1); popd(edx);                              /* pop edx */
            ii(0x100f_d1c9, 1); popd(ecx);                              /* pop ecx */
            ii(0x100f_d1ca, 1); popd(ebx);                              /* pop ebx */
            ii(0x100f_d1cb, 1); retd(); return;                         /* ret */
        }
    }
}
