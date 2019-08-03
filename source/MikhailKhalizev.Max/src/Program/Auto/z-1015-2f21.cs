using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("417a74c7-46f8-49de-9cf9-028afb3cec30")]
        public void Method_1015_2f21()
        {
            ii(0x1015_2f21, 5); pushd(0x30);                            /* push 0x30 */
            ii(0x1015_2f26, 5); calld(Definitions.sys_check_available_stack_size, 0x12e27); /* call 0x10165d52 */
            ii(0x1015_2f2b, 1); pushd(esi);                             /* push esi */
            ii(0x1015_2f2c, 1); pushd(edi);                             /* push edi */
            ii(0x1015_2f2d, 1); pushd(ebp);                             /* push ebp */
            ii(0x1015_2f2e, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1015_2f30, 6); sub(esp, 0x20);                         /* sub esp, 0x20 */
            ii(0x1015_2f36, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1015_2f39, 3); mov(memd_a32[ss, ebp - 0xc], edx);      /* mov [ebp-0xc], edx */
            ii(0x1015_2f3c, 3); mov(memd_a32[ss, ebp - 0x4], ebx);      /* mov [ebp-0x4], ebx */
            ii(0x1015_2f3f, 3); mov(memd_a32[ss, ebp - 0x8], ecx);      /* mov [ebp-0x8], ecx */
            ii(0x1015_2f42, 3); mov(edx, memd_a32[ss, ebp - 0x10]);     /* mov edx, [ebp-0x10] */
            ii(0x1015_2f45, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1015_2f47, 3); mov(cl, memb_a32[ds, edx + 0x2d]);      /* mov cl, [edx+0x2d] */
            ii(0x1015_2f4a, 1); inc(ecx);                               /* inc ecx */
            ii(0x1015_2f4b, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x1015_2f50, 2); shl(edx, cl);                           /* shl edx, cl */
            ii(0x1015_2f52, 3); mov(memd_a32[ss, ebp - 0x14], edx);     /* mov [ebp-0x14], edx */
            ii(0x1015_2f55, 6); mov(edx, memd_a32[ds, 0x101c_38c0]);    /* mov edx, [0x101c38c0] */
            ii(0x1015_2f5b, 2); add(edx, edx);                          /* add edx, edx */
            ii(0x1015_2f5d, 4); movsx(ebx, memw_a32[ss, ebp - 0x14]);   /* movsx ebx, word [ebp-0x14] */
            ii(0x1015_2f61, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1015_2f63, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1015_2f66, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x1015_2f68, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x1015_2f6b, 3); mov(edx, memd_a32[ss, ebp - 0x10]);     /* mov edx, [ebp-0x10] */
            ii(0x1015_2f6e, 3); mov(edx, memd_a32[ds, edx + 0x6]);      /* mov edx, [edx+0x6] */
            ii(0x1015_2f71, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1015_2f74, 3); imul(edx, edx, 0x33);                   /* imul edx, edx, 0x33 */
            ii(0x1015_2f77, 7); cmp(memd_a32[ds, edx + 0x101c_81eb], 0); /* cmp dword [edx+0x101c81eb], 0x0 */
            ii(0x1015_2f7e, 2); if(jzd(0x1015_2f89, 0x9)) goto l_0x1015_2f89; /* jz 0x10152f89 */
            ii(0x1015_2f80, 4); movsx(eax, memw_a32[ss, ebp - 0x18]);   /* movsx eax, word [ebp-0x18] */
            ii(0x1015_2f84, 3); cmp(eax, 0x8);                          /* cmp eax, 0x8 */
            ii(0x1015_2f87, 2); if(jged(0x1015_2f8e, 0x5)) goto l_0x1015_2f8e; /* jge 0x10152f8e */
        l_0x1015_2f89:
            ii(0x1015_2f89, 5); jmpd(0x1015_3019, 0x8b); goto l_0x1015_3019; /* jmp 0x10153019 */
        l_0x1015_2f8e:
            ii(0x1015_2f8e, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1015_2f91, 3); mov(eax, memd_a32[ds, eax + 0x6]);      /* mov eax, [eax+0x6] */
            ii(0x1015_2f94, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1015_2f97, 3); imul(eax, eax, 0x33);                   /* imul eax, eax, 0x33 */
            ii(0x1015_2f9a, 6); mov(eax, memd_a32[ds, eax + 0x101c_81eb]); /* mov eax, [eax+0x101c81eb] */
            ii(0x1015_2fa0, 5); mov(memd_a32[ds, 0x101c_363c], eax);    /* mov [0x101c363c], eax */
            ii(0x1015_2fa5, 4); movsx(edx, memw_a32[ss, ebp - 0x4]);    /* movsx edx, word [ebp-0x4] */
            ii(0x1015_2fa9, 5); mov(eax, memd_a32[ds, 0x101c_363c]);    /* mov eax, [0x101c363c] */
            ii(0x1015_2fae, 5); calld(0x1014_98f1, -0x96c2);            /* call 0x101498f1 */
            ii(0x1015_2fb3, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x1015_2fb6, 3); mov(edx, memd_a32[ss, ebp - 0x10]);     /* mov edx, [ebp-0x10] */
            ii(0x1015_2fb9, 6); add(edx, 0xd9);                         /* add edx, 0xd9 */
            ii(0x1015_2fbf, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1015_2fc2, 5); calld(0x1007_6a6c, -0xdc55b);           /* call 0x10076a6c */
            ii(0x1015_2fc7, 7); cmp(memb_a32[ds, 0x101c_814a], 0);      /* cmp byte [0x101c814a], 0x0 */
            ii(0x1015_2fce, 2); if(jzd(0x1015_2fde, 0xe)) goto l_0x1015_2fde; /* jz 0x10152fde */
            ii(0x1015_2fd0, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1015_2fd3, 2); cwd();                                  /* cwd */
            ii(0x1015_2fd5, 3); sub(ax, dx);                            /* sub ax, dx */
            ii(0x1015_2fd8, 3); sar(ax, 0x1);                           /* sar ax, 1 */
            ii(0x1015_2fdb, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
        l_0x1015_2fde:
            ii(0x1015_2fde, 3); mov(ecx, memd_a32[ss, ebp - 0x8]);      /* mov ecx, [ebp-0x8] */
            ii(0x1015_2fe1, 4); movsx(ebx, memw_a32[ss, ebp - 0x14]);   /* movsx ebx, word [ebp-0x14] */
            ii(0x1015_2fe5, 3); mov(esi, memd_a32[ss, ebp - 0x1c]);     /* mov esi, [ebp-0x1c] */
            ii(0x1015_2fe8, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x1015_2feb, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1015_2fee, 5); calld(0x1007_5e64, -0xdd18f);           /* call 0x10075e64 */
            ii(0x1015_2ff3, 2); mov(edx, esi);                          /* mov edx, esi */
            ii(0x1015_2ff5, 5); calld(0x1015_2cba, -0x340);             /* call 0x10152cba */
            ii(0x1015_2ffa, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1015_2ffc, 2); if(jzd(0x1015_3019, 0x1b)) goto l_0x1015_3019; /* jz 0x10153019 */
            ii(0x1015_2ffe, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x1015_3001, 3); add(eax, 0x8);                          /* add eax, 0x8 */
            ii(0x1015_3004, 5); mov(memd_a32[ds, 0x101c_3634], eax);    /* mov [0x101c3634], eax */
            ii(0x1015_3009, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1015_300c, 3); mov(eax, memd_a32[ds, eax + 0x22]);     /* mov eax, [eax+0x22] */
            ii(0x1015_300f, 5); mov(memd_a32[ds, 0x101c_3640], eax);    /* mov [0x101c3640], eax */
            ii(0x1015_3014, 5); calld(0x100e_fa22, -0x635f7);           /* call 0x100efa22 */
        l_0x1015_3019:
            ii(0x1015_3019, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1015_301b, 1); popd(ebp);                              /* pop ebp */
            ii(0x1015_301c, 1); popd(edi);                              /* pop edi */
            ii(0x1015_301d, 1); popd(esi);                              /* pop esi */
            ii(0x1015_301e, 1); retd(); return;                         /* ret */
        }
    }
}