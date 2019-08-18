using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("008101b3-2c83-4645-85b0-c3cc50a262f7")]
        public void Method_1011_ef28()
        {
            ii(0x1011_ef28, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x1011_ef2d, 5); calld(Definitions.sys_check_available_stack_size, 0x4_6e20); /* call 0x10165d52 */
            ii(0x1011_ef32, 1); pushd(esi);                             /* push esi */
            ii(0x1011_ef33, 1); pushd(edi);                             /* push edi */
            ii(0x1011_ef34, 1); pushd(ebp);                             /* push ebp */
            ii(0x1011_ef35, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1011_ef37, 6); sub(esp, 0x18);                         /* sub esp, 0x18 */
            ii(0x1011_ef3d, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1011_ef40, 3); mov(memd_a32[ss, ebp - 0xc], edx);      /* mov [ebp-0xc], edx */
            ii(0x1011_ef43, 3); mov(memb_a32[ss, ebp - 0x8], bl);       /* mov [ebp-0x8], bl */
            ii(0x1011_ef46, 3); mov(memb_a32[ss, ebp - 0x4], cl);       /* mov [ebp-0x4], cl */
            ii(0x1011_ef49, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1011_ef4c, 4); test(memb_a32[ds, eax + 0x12], 0x40);   /* test byte [eax+0x12], 0x40 */
            ii(0x1011_ef50, 2); if(jzd(0x1011_efa7, 0x55)) goto l_0x1011_efa7; /* jz 0x1011efa7 */
            ii(0x1011_ef52, 7); mov(memd_a32[ss, ebp - 0x14], 0);       /* mov dword [ebp-0x14], 0x0 */
            ii(0x1011_ef59, 2); jmpd(0x1011_ef61, 0x6); goto l_0x1011_ef61; /* jmp 0x1011ef61 */
        l_0x1011_ef5b:
            ii(0x1011_ef5b, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1011_ef5e, 3); inc(memd_a32[ss, ebp - 0x14]);          /* inc dword [ebp-0x14] */
        l_0x1011_ef61:
            ii(0x1011_ef61, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1011_ef64, 7); cmp(ax, memw_a32[ds, 0x101c_8172]);     /* cmp ax, [0x101c8172] */
            ii(0x1011_ef6b, 2); if(jged(0x1011_ef8e, 0x21)) goto l_0x1011_ef8e; /* jge 0x1011ef8e */
            ii(0x1011_ef6d, 6); mov(ebx, memd_a32[ds, 0x101c_8172]);    /* mov ebx, [0x101c8172] */
            ii(0x1011_ef73, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1011_ef76, 5); mov(edx, 0x4);                          /* mov edx, 0x4 */
            ii(0x1011_ef7b, 4); movsx(eax, memw_a32[ss, ebp - 0x14]);   /* movsx eax, word [ebp-0x14] */
            ii(0x1011_ef7f, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1011_ef82, 3); add(eax, memd_a32[ss, ebp - 0xc]);      /* add eax, [ebp-0xc] */
            ii(0x1011_ef85, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1011_ef87, 5); calld(Definitions.sys_memset, 0x4_6e54); /* call 0x10165de0 */
            ii(0x1011_ef8c, 2); jmpd(0x1011_ef5b, -0x33); goto l_0x1011_ef5b; /* jmp 0x1011ef5b */
        l_0x1011_ef8e:
            ii(0x1011_ef8e, 4); movsx(ecx, memb_a32[ss, ebp - 0x8]);    /* movsx ecx, byte [ebp-0x8] */
            ii(0x1011_ef92, 3); mov(ebx, memd_a32[ss, ebp - 0x10]);     /* mov ebx, [ebp-0x10] */
            ii(0x1011_ef95, 5); mov(edx, 0x101c_81a8);                  /* mov edx, 0x101c81a8 */
            ii(0x1011_ef9a, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1011_ef9d, 5); calld(0x1011_e8d9, -0x6c9);             /* call 0x1011e8d9 */
            ii(0x1011_efa2, 5); jmpd(0x1011_f09b, 0xf4); goto l_0x1011_f09b; /* jmp 0x1011f09b */
        l_0x1011_efa7:
            ii(0x1011_efa7, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1011_efaa, 3); mov(edx, memd_a32[ds, eax + 0x6]);      /* mov edx, [eax+0x6] */
            ii(0x1011_efad, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1011_efb0, 3); imul(edx, edx, 0x33);                   /* imul edx, edx, 0x33 */
            ii(0x1011_efb3, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1011_efb5, 6); mov(al, memb_a32[ds, edx + 0x101c_81d4]); /* mov al, [edx+0x101c81d4] */
            ii(0x1011_efbb, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x1011_efbe, 7); mov(memd_a32[ss, ebp - 0x14], 0);       /* mov dword [ebp-0x14], 0x0 */
            ii(0x1011_efc5, 2); jmpd(0x1011_efcd, 0x6); goto l_0x1011_efcd; /* jmp 0x1011efcd */
        l_0x1011_efc7:
            ii(0x1011_efc7, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1011_efca, 3); inc(memd_a32[ss, ebp - 0x14]);          /* inc dword [ebp-0x14] */
        l_0x1011_efcd:
            ii(0x1011_efcd, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1011_efd0, 7); cmp(ax, memw_a32[ds, 0x101c_8172]);     /* cmp ax, [0x101c8172] */
            ii(0x1011_efd7, 2); if(jged(0x1011_eff7, 0x1e)) goto l_0x1011_eff7; /* jge 0x1011eff7 */
            ii(0x1011_efd9, 6); mov(ebx, memd_a32[ds, 0x101c_8172]);    /* mov ebx, [0x101c8172] */
            ii(0x1011_efdf, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1011_efe2, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1011_efe4, 4); movsx(eax, memw_a32[ss, ebp - 0x14]);   /* movsx eax, word [ebp-0x14] */
            ii(0x1011_efe8, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1011_efeb, 3); add(eax, memd_a32[ss, ebp - 0xc]);      /* add eax, [ebp-0xc] */
            ii(0x1011_efee, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1011_eff0, 5); calld(Definitions.sys_memset, 0x4_6deb); /* call 0x10165de0 */
            ii(0x1011_eff5, 2); jmpd(0x1011_efc7, -0x30); goto l_0x1011_efc7; /* jmp 0x1011efc7 */
        l_0x1011_eff7:
            ii(0x1011_eff7, 6); test(memw_a32[ss, ebp - 0x18], 0x1);    /* test word [ebp-0x18], 0x1 */
            ii(0x1011_effd, 2); if(jzd(0x1011_f011, 0x12)) goto l_0x1011_f011; /* jz 0x1011f011 */
            ii(0x1011_efff, 5); mov(ebx, 0x4);                          /* mov ebx, 0x4 */
            ii(0x1011_f004, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x1011_f009, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1011_f00c, 5); calld(0x1011_ea37, -0x5da);             /* call 0x1011ea37 */
        l_0x1011_f011:
            ii(0x1011_f011, 6); test(memw_a32[ss, ebp - 0x18], 0x4);    /* test word [ebp-0x18], 0x4 */
            ii(0x1011_f017, 2); if(jzd(0x1011_f02b, 0x12)) goto l_0x1011_f02b; /* jz 0x1011f02b */
            ii(0x1011_f019, 5); mov(ebx, 0x4);                          /* mov ebx, 0x4 */
            ii(0x1011_f01e, 5); mov(edx, 0x4);                          /* mov edx, 0x4 */
            ii(0x1011_f023, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1011_f026, 5); calld(0x1011_ea37, -0x5f4);             /* call 0x1011ea37 */
        l_0x1011_f02b:
            ii(0x1011_f02b, 6); test(memw_a32[ss, ebp - 0x18], 0x2);    /* test word [ebp-0x18], 0x2 */
            ii(0x1011_f031, 2); if(jzd(0x1011_f06d, 0x3a)) goto l_0x1011_f06d; /* jz 0x1011f06d */
            ii(0x1011_f033, 6); test(memw_a32[ss, ebp - 0x18], 0x1);    /* test word [ebp-0x18], 0x1 */
            ii(0x1011_f039, 2); if(jzd(0x1011_f045, 0xa)) goto l_0x1011_f045; /* jz 0x1011f045 */
            ii(0x1011_f03b, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1011_f03e, 5); cmp(memw_a32[ds, eax + 0x8], 0x39);     /* cmp word [eax+0x8], 0x39 */
            ii(0x1011_f043, 2); if(jnzd(0x1011_f047, 0x2)) goto l_0x1011_f047; /* jnz 0x1011f047 */
        l_0x1011_f045:
            ii(0x1011_f045, 2); jmpd(0x1011_f05b, 0x14); goto l_0x1011_f05b; /* jmp 0x1011f05b */
        l_0x1011_f047:
            ii(0x1011_f047, 5); mov(ebx, 0x8);                          /* mov ebx, 0x8 */
            ii(0x1011_f04c, 5); mov(edx, 0x2);                          /* mov edx, 0x2 */
            ii(0x1011_f051, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1011_f054, 5); calld(0x1011_ea37, -0x622);             /* call 0x1011ea37 */
            ii(0x1011_f059, 2); jmpd(0x1011_f06d, 0x12); goto l_0x1011_f06d; /* jmp 0x1011f06d */
        l_0x1011_f05b:
            ii(0x1011_f05b, 5); mov(ebx, 0x4);                          /* mov ebx, 0x4 */
            ii(0x1011_f060, 5); mov(edx, 0x2);                          /* mov edx, 0x2 */
            ii(0x1011_f065, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1011_f068, 5); calld(0x1011_ea37, -0x636);             /* call 0x1011ea37 */
        l_0x1011_f06d:
            ii(0x1011_f06d, 4); movsx(ebx, memw_a32[ss, ebp - 0x18]);   /* movsx ebx, word [ebp-0x18] */
            ii(0x1011_f071, 3); mov(edx, memd_a32[ss, ebp - 0x10]);     /* mov edx, [ebp-0x10] */
            ii(0x1011_f074, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1011_f077, 5); calld(0x1011_eac8, -0x5b4);             /* call 0x1011eac8 */
            ii(0x1011_f07c, 4); movsx(ecx, memb_a32[ss, ebp - 0x8]);    /* movsx ecx, byte [ebp-0x8] */
            ii(0x1011_f080, 3); mov(ebx, memd_a32[ss, ebp - 0x10]);     /* mov ebx, [ebp-0x10] */
            ii(0x1011_f083, 5); mov(edx, 0x101c_8184);                  /* mov edx, 0x101c8184 */
            ii(0x1011_f088, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1011_f08b, 5); calld(0x1011_e8d9, -0x7b7);             /* call 0x1011e8d9 */
            ii(0x1011_f090, 3); mov(edx, memd_a32[ss, ebp - 0x10]);     /* mov edx, [ebp-0x10] */
            ii(0x1011_f093, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1011_f096, 5); calld(0x1011_e78d, -0x90e);             /* call 0x1011e78d */
        l_0x1011_f09b:
            ii(0x1011_f09b, 4); cmp(memb_a32[ss, ebp - 0x4], 0);        /* cmp byte [ebp-0x4], 0x0 */
            ii(0x1011_f09f, 2); if(jled(0x1011_f0b0, 0xf)) goto l_0x1011_f0b0; /* jle 0x1011f0b0 */
            ii(0x1011_f0a1, 4); movsx(ebx, memb_a32[ss, ebp - 0x4]);    /* movsx ebx, byte [ebp-0x4] */
            ii(0x1011_f0a5, 3); mov(edx, memd_a32[ss, ebp - 0x10]);     /* mov edx, [ebp-0x10] */
            ii(0x1011_f0a8, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1011_f0ab, 5); calld(0x100c_9e2e, -0x5_5282);          /* call 0x100c9e2e */
        l_0x1011_f0b0:
            ii(0x1011_f0b0, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1011_f0b2, 1); popd(ebp);                              /* pop ebp */
            ii(0x1011_f0b3, 1); popd(edi);                              /* pop edi */
            ii(0x1011_f0b4, 1); popd(esi);                              /* pop esi */
            ii(0x1011_f0b5, 1); retd(); return;                         /* ret */
        }
    }
}
