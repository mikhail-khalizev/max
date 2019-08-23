using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1010_8aa1-f929a80d")]
        public void Method_1010_8aa1()
        {
            ii(0x1010_8aa1, 5); pushd(0x228);                           /* push 0x228 */
            ii(0x1010_8aa6, 5); calld(Definitions.sys_check_available_stack_size, 0x5_d2a7); /* call 0x10165d52 */
            ii(0x1010_8aab, 1); pushd(esi);                             /* push esi */
            ii(0x1010_8aac, 1); pushd(edi);                             /* push edi */
            ii(0x1010_8aad, 1); pushd(ebp);                             /* push ebp */
            ii(0x1010_8aae, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1010_8ab0, 6); sub(esp, 0x214);                        /* sub esp, 0x214 */
            ii(0x1010_8ab6, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1010_8ab9, 3); mov(memd_a32[ss, ebp - 0xc], edx);      /* mov [ebp-0xc], edx */
            ii(0x1010_8abc, 3); mov(memd_a32[ss, ebp - 0x8], ebx);      /* mov [ebp-0x8], ebx */
            ii(0x1010_8abf, 3); mov(memd_a32[ss, ebp - 0x4], ecx);      /* mov [ebp-0x4], ecx */
            ii(0x1010_8ac2, 4); movsx(edx, memw_a32[ss, ebp - 0x8]);    /* movsx edx, word [ebp-0x8] */
            ii(0x1010_8ac6, 5); mov(ebx, 0x5);                          /* mov ebx, 0x5 */
            ii(0x1010_8acb, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1010_8acd, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1010_8ad0, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x1010_8ad2, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1010_8ad4, 2); if(jzd(0x1010_8adc, 0x6)) goto l_0x1010_8adc; /* jz 0x10108adc */
            ii(0x1010_8ad6, 4); mov(memb_a32[ss, ebp - 0x18], 0xa);     /* mov byte [ebp-0x18], 0xa */
            ii(0x1010_8ada, 2); jmpd(0x1010_8ae0, 0x4); goto l_0x1010_8ae0; /* jmp 0x10108ae0 */
        l_0x1010_8adc:
            ii(0x1010_8adc, 4); mov(memb_a32[ss, ebp - 0x18], 0x9);     /* mov byte [ebp-0x18], 0x9 */
        l_0x1010_8ae0:
            ii(0x1010_8ae0, 3); mov(al, memb_a32[ss, ebp - 0x18]);      /* mov al, [ebp-0x18] */
            ii(0x1010_8ae3, 3); mov(memb_a32[ss, ebp - 0x14], al);      /* mov [ebp-0x14], al */
            ii(0x1010_8ae6, 4); movsx(edx, memw_a32[ss, ebp - 0x8]);    /* movsx edx, word [ebp-0x8] */
            ii(0x1010_8aea, 5); mov(ebx, 0x5);                          /* mov ebx, 0x5 */
            ii(0x1010_8aef, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1010_8af1, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1010_8af4, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x1010_8af6, 3); mov(memd_a32[ss, ebp - 0x20], edx);     /* mov [ebp-0x20], edx */
            ii(0x1010_8af9, 5); mov(eax, 0x5);                          /* mov eax, 0x5 */
            ii(0x1010_8afe, 3); sub(eax, memd_a32[ss, ebp - 0x20]);     /* sub eax, [ebp-0x20] */
            ii(0x1010_8b01, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x1010_8b04, 7); mov(memb_a32[ss, ebp - 0x214], 0);      /* mov byte [ebp-0x214], 0x0 */
        l_0x1010_8b0b:
            ii(0x1010_8b0b, 3); dec(memd_a32[ss, ebp - 0x20]);          /* dec dword [ebp-0x20] */
            ii(0x1010_8b0e, 5); cmp(memw_a32[ss, ebp - 0x20], -0x1 /* 0xff */); /* cmp word [ebp-0x20], 0xffff */
            ii(0x1010_8b13, 2); if(jzd(0x1010_8b27, 0x12)) goto l_0x1010_8b27; /* jz 0x10108b27 */
            ii(0x1010_8b15, 5); mov(edx, StringDefinitions.Control38);  /* mov edx, 0x101a456e */
            ii(0x1010_8b1a, 6); lea(eax, ebp - 0x214);                  /* lea eax, [ebp-0x214] */
            ii(0x1010_8b20, 5); calld(Definitions.sys_strcat, 0x5_d40c); /* call 0x10165f31 */
            ii(0x1010_8b25, 2); jmpd(0x1010_8b0b, -0x1c); goto l_0x1010_8b0b; /* jmp 0x10108b0b */
        l_0x1010_8b27:
            ii(0x1010_8b27, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x1010_8b2a, 6); lea(eax, ebp - 0x214);                  /* lea eax, [ebp-0x214] */
            ii(0x1010_8b30, 5); calld(Definitions.sys_strcat, 0x5_d3fc); /* call 0x10165f31 */
        l_0x1010_8b35:
            ii(0x1010_8b35, 3); dec(memd_a32[ss, ebp - 0x1c]);          /* dec dword [ebp-0x1c] */
            ii(0x1010_8b38, 5); cmp(memw_a32[ss, ebp - 0x1c], -0x1 /* 0xff */); /* cmp word [ebp-0x1c], 0xffff */
            ii(0x1010_8b3d, 2); if(jzd(0x1010_8b51, 0x12)) goto l_0x1010_8b51; /* jz 0x10108b51 */
            ii(0x1010_8b3f, 5); mov(edx, StringDefinitions.Control39);  /* mov edx, 0x101a4570 */
            ii(0x1010_8b44, 6); lea(eax, ebp - 0x214);                  /* lea eax, [ebp-0x214] */
            ii(0x1010_8b4a, 5); calld(Definitions.sys_strcat, 0x5_d3e2); /* call 0x10165f31 */
            ii(0x1010_8b4f, 2); jmpd(0x1010_8b35, -0x1c); goto l_0x1010_8b35; /* jmp 0x10108b35 */
        l_0x1010_8b51:
            ii(0x1010_8b51, 4); movsx(edx, memb_a32[ss, ebp - 0x14]);   /* movsx edx, byte [ebp-0x14] */
            ii(0x1010_8b55, 3); imul(edx, edx, 0x14);                   /* imul edx, edx, 0x14 */
            ii(0x1010_8b58, 6); lea(eax, ebp - 0x214);                  /* lea eax, [ebp-0x214] */
            ii(0x1010_8b5e, 6); mov(memd_a32[ds, edx + 0x101b_9960], eax); /* mov [edx+0x101b9960], eax */
            ii(0x1010_8b64, 5); calld(0x1011_5318, 0xc7af);             /* call 0x10115318 */
            ii(0x1010_8b69, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1010_8b6e, 1); pushd(eax);                             /* push eax */
            ii(0x1010_8b6f, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1010_8b71, 4); movsx(ebx, memw_a32[ss, ebp - 0x4]);    /* movsx ebx, word [ebp-0x4] */
            ii(0x1010_8b75, 6); or(ebx, 0x1_0000);                      /* or ebx, 0x10000 */
            ii(0x1010_8b7b, 4); movsx(edx, memb_a32[ss, ebp - 0x14]);   /* movsx edx, byte [ebp-0x14] */
            ii(0x1010_8b7f, 3); imul(edx, edx, 0x14);                   /* imul edx, edx, 0x14 */
            ii(0x1010_8b82, 5); mov(eax, 0x101b_9950);                  /* mov eax, 0x101b9950 */
            ii(0x1010_8b87, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1010_8b89, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1010_8b8c, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1010_8b8e, 5); calld(0x1010_8a05, -0x18e);             /* call 0x10108a05 */
            ii(0x1010_8b93, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1010_8b95, 1); popd(ebp);                              /* pop ebp */
            ii(0x1010_8b96, 1); popd(edi);                              /* pop edi */
            ii(0x1010_8b97, 1); popd(esi);                              /* pop esi */
            ii(0x1010_8b98, 1); retd();                                 /* ret */
        }
    }
}
