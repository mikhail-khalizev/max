using System.Linq;
using MikhailKhalizev.Processor.x86.BinToCSharp.HighLevel;
using MikhailKhalizev.Processor.x86.BinToCSharp.LowLevel;
using MikhailKhalizev.Processor.x86.BinToCSharp.MethodInfo;
using SharpDisasm;
using Xunit;

namespace MikhailKhalizev.Processor.x86.Tests.BinToCSharp.HighLevel
{
    public class HighLevelEngineTests
    {
        [Fact]
        public void DecodeStrCaseCmp()
        {
            var mi = new MethodInfoDto();
            mi.Id = "0x1016_6130-63cf5e5f";
            mi.Address = 0x1016_6130;
            mi.Mode = ArchitectureMode.x86_32;
            mi.Raw = "535189c38a0331c98a2288c183f9417c0783f95a7f02042031c988e183f9417c0883f95a7f0380c42038e0750884e474044342ebcf31d288c288e025ff00000029c289d0595bc3";

            //var hl = Decode(mi);
        }

#if false

            ii(0x1016_6130, 1); push(ebx);                              /* push ebx */
            ii(0x1016_6131, 1); push(ecx);                              /* push ecx */
            ii(0x1016_6132, 2); mov(ebx, eax);                          /* mov ebx, eax */
        l_0x1016_6134:
            ii(0x1016_6134, 2); mov(al, memb[ds, ebx]);                 /* mov al, [ebx] */
            ii(0x1016_6136, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1016_6138, 2); mov(ah, memb[ds, edx]);                 /* mov ah, [edx] */
            ii(0x1016_613a, 2); mov(cl, al);                            /* mov cl, al */
            ii(0x1016_613c, 3); cmp(ecx, 0x41);                         /* cmp ecx, 0x41 */
            ii(0x1016_613f, 2); if(jl(0x1016_6148, 0x7)) goto l_0x1016_6148; /* jl 0x10166148 */
            ii(0x1016_6141, 3); cmp(ecx, 0x5a);                         /* cmp ecx, 0x5a */
            ii(0x1016_6144, 2); if(jg(0x1016_6148, 0x2)) goto l_0x1016_6148; /* jg 0x10166148 */
            ii(0x1016_6146, 2); add(al, 0x20);                          /* add al, 0x20 */
        l_0x1016_6148:
            ii(0x1016_6148, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1016_614a, 2); mov(cl, ah);                            /* mov cl, ah */
            ii(0x1016_614c, 3); cmp(ecx, 0x41);                         /* cmp ecx, 0x41 */
            ii(0x1016_614f, 2); if(jl(0x1016_6159, 0x8)) goto l_0x1016_6159; /* jl 0x10166159 */
            ii(0x1016_6151, 3); cmp(ecx, 0x5a);                         /* cmp ecx, 0x5a */
            ii(0x1016_6154, 2); if(jg(0x1016_6159, 0x3)) goto l_0x1016_6159; /* jg 0x10166159 */
            ii(0x1016_6156, 3); add(ah, 0x20);                          /* add ah, 0x20 */
        l_0x1016_6159:
            ii(0x1016_6159, 2); cmp(al, ah);                            /* cmp al, ah */
            ii(0x1016_615b, 2); if(jnz(0x1016_6165, 0x8)) goto l_0x1016_6165; /* jnz 0x10166165 */
            ii(0x1016_615d, 2); test(ah, ah);                           /* test ah, ah */
            ii(0x1016_615f, 2); if(jz(0x1016_6165, 0x4)) goto l_0x1016_6165; /* jz 0x10166165 */
            ii(0x1016_6161, 1); inc(ebx);                               /* inc ebx */
            ii(0x1016_6162, 1); inc(edx);                               /* inc edx */
            ii(0x1016_6163, 2); jmp(0x1016_6134, -0x31); goto l_0x1016_6134; /* jmp 0x10166134 */
        l_0x1016_6165:
            ii(0x1016_6165, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1016_6167, 2); mov(dl, al);                            /* mov dl, al */
            ii(0x1016_6169, 2); mov(al, ah);                            /* mov al, ah */
            ii(0x1016_616b, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1016_6170, 2); sub(edx, eax);                          /* sub edx, eax */
            ii(0x1016_6172, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1016_6174, 1); pop(ecx);                               /* pop ecx */
            ii(0x1016_6175, 1); pop(ebx);                               /* pop ebx */
            ii(0x1016_6176, 1); ret();                                  /* ret */

#endif


        [Fact(Skip = "In develop")]
        public void DecodeMethod_1008_a330()
        {
            var mi = new MethodInfoDto();
            mi.Id = "0x1008_a330-2ff6c19c";
            mi.Address = 0x1008_a330;
            mi.Mode = ArchitectureMode.x86_32;
            mi.Raw = "6828000000e818ba0d0053515256575589e581ec0c0000008945fc8b45fce8f1cafeff8945fc8d45fc8945f88b45fc8945f48b45f489ec5d5f5e5a595bc3";

            var hl = Decode(mi);
        }

#if false

        [MethodInfo("0x1008_a330-2ff6c19c")]
        public void Method_1008_a330()
        {
            ii(0x1008_a330, 5);  push(0x28);                           /* push 0x28 */
            ii(0x1008_a335, 5);  call(Definitions.sys_check_available_stack_size, 0xd_ba18);/* call 0x10165d52 */
            ii(0x1008_a33a, 1);  push(ebx);                            /* push ebx */
            ii(0x1008_a33b, 1);  push(ecx);                            /* push ecx */
            ii(0x1008_a33c, 1);  push(edx);                            /* push edx */
            ii(0x1008_a33d, 1);  push(esi);                            /* push esi */
            ii(0x1008_a33e, 1);  push(edi);                            /* push edi */
            ii(0x1008_a33f, 1);  push(ebp);                            /* push ebp */
            ii(0x1008_a340, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1008_a342, 6);  sub(esp, 0xc);                        /* sub esp, 0xc */
            ii(0x1008_a348, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1008_a34b, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_a34e, 5);  call(Definitions.my_ctor_0x101b_6edc, -0x1_350f);/* call 0x10076e44 */
            ii(0x1008_a353, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1008_a356, 3);  lea(eax, memd[ss, ebp - 4]);          /* lea eax, [ebp-0x4] */
            ii(0x1008_a359, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1008_a35c, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_a35f, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1008_a362, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1008_a365, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1008_a367, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1008_a368, 1);  pop(edi);                             /* pop edi */
            ii(0x1008_a369, 1);  pop(esi);                             /* pop esi */
            ii(0x1008_a36a, 1);  pop(edx);                             /* pop edx */
            ii(0x1008_a36b, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1008_a36c, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1008_a36d, 1);  ret();                                /* ret */
        }

#endif

        
        [Fact(Skip = "In develop")]
        public void DecodeMethod_1013_3a88()
        {
            var mi = new MethodInfoDto();
            mi.Id = "0x1013_3a88-a34a92f7";
            mi.Address = 0x1013_3a88;
            mi.Mode = ArchitectureMode.x86_32;
            mi.Raw = "6844000000e8c022030056575589e581ec340000008945f08955f4895df8884dfcc745e8ffffff7fc745e400000000eb048345e4030fbf45e43d000300000f8dea000000807dfc0075360fbf45e483f81b7c090fbf45e483f85d7e02eb05e9c60000000fbf45e43d200100007c0b0fbf45e43d7d0100007e02eb05e9a90000000fbf55e4a164941c1001d08a0025ff0000008945e00fbf45f08b55e029c28955dc0fbf45e48b1564941c1001d08a400125ff0000008945e00fbf45f48b55e029c28955d80fbf55e4a164941c1001d08a400225ff0000008945e00fbf45f88b55e029c28955d48b55dc0faf55dc8b45d80faf45d801c28b45d40faf45d401c28955d08b45d03b45e87d1f8b45d08945e80fbf55e4bb0300000089d0c1fa1ff7fb8945cc837dd0007405e903ffffff8a45cc8845ec8a45ec89ec5d5f5ec3";
            
            var hl = Decode(mi);
        }

#if false
        
        [MethodInfo("0x1013_3a88-a34a92f7")]
        public void Method_1013_3a88()
        {
            ii(0x1013_3a88, 5); push(0x44);                             /* push 0x44 */
            ii(0x1013_3a8d, 5); call(Definitions.sys_check_available_stack_size, 0x3_22c0); /* call 0x10165d52 */
            ii(0x1013_3a92, 1); push(esi);                              /* push esi */
            ii(0x1013_3a93, 1); push(edi);                              /* push edi */
            ii(0x1013_3a94, 1); push(ebp);                              /* push ebp */
            ii(0x1013_3a95, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_3a97, 6); sub(esp, 0x34);                         /* sub esp, 0x34 */
            ii(0x1013_3a9d, 3); mov(memd[ss, ebp - 16], eax);           /* mov [ebp-0x10], eax */
            ii(0x1013_3aa0, 3); mov(memd[ss, ebp - 12], edx);           /* mov [ebp-0xc], edx */
            ii(0x1013_3aa3, 3); mov(memd[ss, ebp - 8], ebx);            /* mov [ebp-0x8], ebx */
            ii(0x1013_3aa6, 3); mov(memb[ss, ebp - 4], cl);             /* mov [ebp-0x4], cl */
            ii(0x1013_3aa9, 7); mov(memd[ss, ebp - 24], 0x7fff_ffff);   /* mov dword [ebp-0x18], 0x7fffffff */
            ii(0x1013_3ab0, 7); mov(memd[ss, ebp - 28], 0);             /* mov dword [ebp-0x1c], 0x0 */
            ii(0x1013_3ab7, 2); jmp(0x1013_3abd, 4); goto l_0x1013_3abd; /* jmp 0x10133abd */
        l_0x1013_3ab9:
            ii(0x1013_3ab9, 4); add(memd[ss, ebp - 28], 3);             /* add dword [ebp-0x1c], 0x3 */
        l_0x1013_3abd:
            ii(0x1013_3abd, 4); movsx(eax, memw[ss, ebp - 28]);         /* movsx eax, word [ebp-0x1c] */
            ii(0x1013_3ac1, 5); cmp(eax, 0x300);                        /* cmp eax, 0x300 */
            ii(0x1013_3ac6, 6); if(jge(0x1013_3bb6, 0xea)) goto l_0x1013_3bb6; /* jge 0x10133bb6 */
            ii(0x1013_3acc, 4); cmp(memb[ss, ebp - 4], 0);              /* cmp byte [ebp-0x4], 0x0 */
            ii(0x1013_3ad0, 2); if(jnz(0x1013_3b08, 0x36)) goto l_0x1013_3b08; /* jnz 0x10133b08 */
            ii(0x1013_3ad2, 4); movsx(eax, memw[ss, ebp - 28]);         /* movsx eax, word [ebp-0x1c] */
            ii(0x1013_3ad6, 3); cmp(eax, 0x1b);                         /* cmp eax, 0x1b */
            ii(0x1013_3ad9, 2); if(jl(0x1013_3ae4, 9)) goto l_0x1013_3ae4; /* jl 0x10133ae4 */
            ii(0x1013_3adb, 4); movsx(eax, memw[ss, ebp - 28]);         /* movsx eax, word [ebp-0x1c] */
            ii(0x1013_3adf, 3); cmp(eax, 0x5d);                         /* cmp eax, 0x5d */
            ii(0x1013_3ae2, 2); if(jle(0x1013_3ae6, 2)) goto l_0x1013_3ae6; /* jle 0x10133ae6 */
        l_0x1013_3ae4:
            ii(0x1013_3ae4, 2); jmp(0x1013_3aeb, 5); goto l_0x1013_3aeb; /* jmp 0x10133aeb */
        l_0x1013_3ae6:
            ii(0x1013_3ae6, 5); jmp(0x1013_3bb1, 0xc6); goto l_0x1013_3bb1; /* jmp 0x10133bb1 */
        l_0x1013_3aeb:
            ii(0x1013_3aeb, 4); movsx(eax, memw[ss, ebp - 28]);         /* movsx eax, word [ebp-0x1c] */
            ii(0x1013_3aef, 5); cmp(eax, 0x120);                        /* cmp eax, 0x120 */
            ii(0x1013_3af4, 2); if(jl(0x1013_3b01, 0xb)) goto l_0x1013_3b01; /* jl 0x10133b01 */
            ii(0x1013_3af6, 4); movsx(eax, memw[ss, ebp - 28]);         /* movsx eax, word [ebp-0x1c] */
            ii(0x1013_3afa, 5); cmp(eax, 0x17d);                        /* cmp eax, 0x17d */
            ii(0x1013_3aff, 2); if(jle(0x1013_3b03, 2)) goto l_0x1013_3b03; /* jle 0x10133b03 */
        l_0x1013_3b01:
            ii(0x1013_3b01, 2); jmp(0x1013_3b08, 5); goto l_0x1013_3b08; /* jmp 0x10133b08 */
        l_0x1013_3b03:
            ii(0x1013_3b03, 5); jmp(0x1013_3bb1, 0xa9); goto l_0x1013_3bb1; /* jmp 0x10133bb1 */
        l_0x1013_3b08:
            ii(0x1013_3b08, 4); movsx(edx, memw[ss, ebp - 28]);         /* movsx edx, word [ebp-0x1c] */
            ii(0x1013_3b0c, 5); mov(eax, memd[ds, Definitions.ptr_to_pallete]); /* mov eax, [0x101c9464] */
            ii(0x1013_3b11, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1013_3b13, 2); mov(al, memb[ds, eax]);                 /* mov al, [eax] */
            ii(0x1013_3b15, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1013_3b1a, 3); mov(memd[ss, ebp - 32], eax);           /* mov [ebp-0x20], eax */
            ii(0x1013_3b1d, 4); movsx(eax, memw[ss, ebp - 16]);         /* movsx eax, word [ebp-0x10] */
            ii(0x1013_3b21, 3); mov(edx, memd[ss, ebp - 32]);           /* mov edx, [ebp-0x20] */
            ii(0x1013_3b24, 2); sub(edx, eax);                          /* sub edx, eax */
            ii(0x1013_3b26, 3); mov(memd[ss, ebp - 36], edx);           /* mov [ebp-0x24], edx */
            ii(0x1013_3b29, 4); movsx(eax, memw[ss, ebp - 28]);         /* movsx eax, word [ebp-0x1c] */
            ii(0x1013_3b2d, 6); mov(edx, memd[ds, Definitions.ptr_to_pallete]); /* mov edx, [0x101c9464] */
            ii(0x1013_3b33, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1013_3b35, 3); mov(al, memb[ds, eax + 1]);             /* mov al, [eax+0x1] */
            ii(0x1013_3b38, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1013_3b3d, 3); mov(memd[ss, ebp - 32], eax);           /* mov [ebp-0x20], eax */
            ii(0x1013_3b40, 4); movsx(eax, memw[ss, ebp - 12]);         /* movsx eax, word [ebp-0xc] */
            ii(0x1013_3b44, 3); mov(edx, memd[ss, ebp - 32]);           /* mov edx, [ebp-0x20] */
            ii(0x1013_3b47, 2); sub(edx, eax);                          /* sub edx, eax */
            ii(0x1013_3b49, 3); mov(memd[ss, ebp - 40], edx);           /* mov [ebp-0x28], edx */
            ii(0x1013_3b4c, 4); movsx(edx, memw[ss, ebp - 28]);         /* movsx edx, word [ebp-0x1c] */
            ii(0x1013_3b50, 5); mov(eax, memd[ds, Definitions.ptr_to_pallete]); /* mov eax, [0x101c9464] */
            ii(0x1013_3b55, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1013_3b57, 3); mov(al, memb[ds, eax + 2]);             /* mov al, [eax+0x2] */
            ii(0x1013_3b5a, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1013_3b5f, 3); mov(memd[ss, ebp - 32], eax);           /* mov [ebp-0x20], eax */
            ii(0x1013_3b62, 4); movsx(eax, memw[ss, ebp - 8]);          /* movsx eax, word [ebp-0x8] */
            ii(0x1013_3b66, 3); mov(edx, memd[ss, ebp - 32]);           /* mov edx, [ebp-0x20] */
            ii(0x1013_3b69, 2); sub(edx, eax);                          /* sub edx, eax */
            ii(0x1013_3b6b, 3); mov(memd[ss, ebp - 44], edx);           /* mov [ebp-0x2c], edx */
            ii(0x1013_3b6e, 3); mov(edx, memd[ss, ebp - 36]);           /* mov edx, [ebp-0x24] */
            ii(0x1013_3b71, 4); imul(edx, memd[ss, ebp - 36]);          /* imul edx, [ebp-0x24] */
            ii(0x1013_3b75, 3); mov(eax, memd[ss, ebp - 40]);           /* mov eax, [ebp-0x28] */
            ii(0x1013_3b78, 4); imul(eax, memd[ss, ebp - 40]);          /* imul eax, [ebp-0x28] */
            ii(0x1013_3b7c, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1013_3b7e, 3); mov(eax, memd[ss, ebp - 44]);           /* mov eax, [ebp-0x2c] */
            ii(0x1013_3b81, 4); imul(eax, memd[ss, ebp - 44]);          /* imul eax, [ebp-0x2c] */
            ii(0x1013_3b85, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1013_3b87, 3); mov(memd[ss, ebp - 48], edx);           /* mov [ebp-0x30], edx */
            ii(0x1013_3b8a, 3); mov(eax, memd[ss, ebp - 48]);           /* mov eax, [ebp-0x30] */
            ii(0x1013_3b8d, 3); cmp(eax, memd[ss, ebp - 24]);           /* cmp eax, [ebp-0x18] */
            ii(0x1013_3b90, 2); if(jge(0x1013_3bb1, 0x1f)) goto l_0x1013_3bb1; /* jge 0x10133bb1 */
            ii(0x1013_3b92, 3); mov(eax, memd[ss, ebp - 48]);           /* mov eax, [ebp-0x30] */
            ii(0x1013_3b95, 3); mov(memd[ss, ebp - 24], eax);           /* mov [ebp-0x18], eax */
            ii(0x1013_3b98, 4); movsx(edx, memw[ss, ebp - 28]);         /* movsx edx, word [ebp-0x1c] */
            ii(0x1013_3b9c, 5); mov(ebx, 3);                            /* mov ebx, 0x3 */
            ii(0x1013_3ba1, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1013_3ba3, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1013_3ba6, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x1013_3ba8, 3); mov(memd[ss, ebp - 52], eax);           /* mov [ebp-0x34], eax */
            ii(0x1013_3bab, 4); cmp(memd[ss, ebp - 48], 0);             /* cmp dword [ebp-0x30], 0x0 */
            ii(0x1013_3baf, 2); if(jz(0x1013_3bb6, 5)) goto l_0x1013_3bb6; /* jz 0x10133bb6 */
        l_0x1013_3bb1:
            ii(0x1013_3bb1, 5); jmp(0x1013_3ab9, -0xfd); goto l_0x1013_3ab9; /* jmp 0x10133ab9 */
        l_0x1013_3bb6:
            ii(0x1013_3bb6, 3); mov(al, memb[ss, ebp - 52]);            /* mov al, [ebp-0x34] */
            ii(0x1013_3bb9, 3); mov(memb[ss, ebp - 20], al);            /* mov [ebp-0x14], al */
            ii(0x1013_3bbc, 3); mov(al, memb[ss, ebp - 20]);            /* mov al, [ebp-0x14] */
            ii(0x1013_3bbf, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_3bc1, 1); pop(ebp);                               /* pop ebp */
            ii(0x1013_3bc2, 1); pop(edi);                               /* pop edi */
            ii(0x1013_3bc3, 1); pop(esi);                               /* pop esi */
            ii(0x1013_3bc4, 1); ret();                                  /* ret */
        }

#endif
        
        
        [Fact(Skip = "In develop")]
        public void DecodeMethod_1012_3850()
        {
            var mi = new MethodInfoDto();
            mi.Id = "0x1012_3850-81dcc4f2";
            mi.Address = 0x1012_3850;
            mi.Mode = ArchitectureMode.x86_32;
            mi.Raw = "6830000000e8f82404005356575589e581ec1c000000c745fc000000008b45148b80900000008945e88b45148b80940000008945f88b45148b90840000008b45148b808800000001d08945f48b45188945f08b45e88a108b45f03a100f85de0000008b45e88945ec8b45e8ff45e88b45f0ff45f08b45f8ff45f88b45e88a108b45f03a1075088b45e83b45f47202eb148b45e8ff45e88b45f0ff45f08b45f8ff45f8ebd68b45f08a0025ff00000085c00f858a0000008b45e83b45f473088b45e880383d7502eb0f8b45e88a0025ff00000083f80d7502eb0e8b45e8ff45e88b45f8ff45f8ebcf8b45e83b45f473088b45e880383d7402eb1a8b45e8ff45e88b45f8ff45f88b45e88b55148982a0000000eb0d8b4514c780a0000000000000008b45ec8b551489829c0000008b4514c780a400000000000000c745fc01000000837dfc0075278b45e83b45f4730f8b45e88a0025ff00000083f80a7502eb0e8b45e8ff45e88b45f8ff45f8ebd98b45e83b45f473068b45e8ff45e88b45f8ff45f8837dfc0075088b45e83b45f47202eb088b45e880385b7502eb05e9acfeffff8b45fc8945e48b45e489ec5d5f5e5bc3";
            
            var hl = Decode(mi);
        }

#if false

        [MethodInfo("0x1012_3850-81dcc4f2")]
        public void Method_1012_3850()
        {
            ii(0x1012_3850, 5); push(0x30);                             /* push 0x30 */
            ii(0x1012_3855, 5); call(Definitions.sys_check_available_stack_size, 0x4_24f8); /* call 0x10165d52 */
            ii(0x1012_385a, 1); push(ebx);                              /* push ebx */
            ii(0x1012_385b, 1); push(esi);                              /* push esi */
            ii(0x1012_385c, 1); push(edi);                              /* push edi */
            ii(0x1012_385d, 1); push(ebp);                              /* push ebp */
            ii(0x1012_385e, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1012_3860, 6); sub(esp, 0x1c);                         /* sub esp, 0x1c */
            ii(0x1012_3866, 7); mov(memd[ss, ebp - 4], 0);              /* mov dword [ebp-0x4], 0x0 */
            ii(0x1012_386d, 3); mov(eax, memd[ss, ebp + 20]);           /* mov eax, [ebp+0x14] */
            ii(0x1012_3870, 6); mov(eax, memd[ds, eax + 144]);          /* mov eax, [eax+0x90] */
            ii(0x1012_3876, 3); mov(memd[ss, ebp - 24], eax);           /* mov [ebp-0x18], eax */
            ii(0x1012_3879, 3); mov(eax, memd[ss, ebp + 20]);           /* mov eax, [ebp+0x14] */
            ii(0x1012_387c, 6); mov(eax, memd[ds, eax + 148]);          /* mov eax, [eax+0x94] */
            ii(0x1012_3882, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1012_3885, 3); mov(eax, memd[ss, ebp + 20]);           /* mov eax, [ebp+0x14] */
            ii(0x1012_3888, 6); mov(edx, memd[ds, eax + 132]);          /* mov edx, [eax+0x84] */
            ii(0x1012_388e, 3); mov(eax, memd[ss, ebp + 20]);           /* mov eax, [ebp+0x14] */
            ii(0x1012_3891, 6); mov(eax, memd[ds, eax + 136]);          /* mov eax, [eax+0x88] */
            ii(0x1012_3897, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1012_3899, 3); mov(memd[ss, ebp - 12], eax);           /* mov [ebp-0xc], eax */
        l_0x1012_389c:
            ii(0x1012_389c, 3); mov(eax, memd[ss, ebp + 24]);           /* mov eax, [ebp+0x18] */
            ii(0x1012_389f, 3); mov(memd[ss, ebp - 16], eax);           /* mov [ebp-0x10], eax */
            ii(0x1012_38a2, 3); mov(eax, memd[ss, ebp - 24]);           /* mov eax, [ebp-0x18] */
            ii(0x1012_38a5, 2); mov(dl, memb[ds, eax]);                 /* mov dl, [eax] */
            ii(0x1012_38a7, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x1012_38aa, 2); cmp(dl, memb[ds, eax]);                 /* cmp dl, [eax] */
            ii(0x1012_38ac, 6); if(jnz(0x1012_3990, 0xde)) goto l_0x1012_3990; /* jnz 0x10123990 */
            ii(0x1012_38b2, 3); mov(eax, memd[ss, ebp - 24]);           /* mov eax, [ebp-0x18] */
            ii(0x1012_38b5, 3); mov(memd[ss, ebp - 20], eax);           /* mov [ebp-0x14], eax */
            ii(0x1012_38b8, 3); mov(eax, memd[ss, ebp - 24]);           /* mov eax, [ebp-0x18] */
            ii(0x1012_38bb, 3); inc(memd[ss, ebp - 24]);                /* inc dword [ebp-0x18] */
            ii(0x1012_38be, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x1012_38c1, 3); inc(memd[ss, ebp - 16]);                /* inc dword [ebp-0x10] */
            ii(0x1012_38c4, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1012_38c7, 3); inc(memd[ss, ebp - 8]);                 /* inc dword [ebp-0x8] */
        l_0x1012_38ca:
            ii(0x1012_38ca, 3); mov(eax, memd[ss, ebp - 24]);           /* mov eax, [ebp-0x18] */
            ii(0x1012_38cd, 2); mov(dl, memb[ds, eax]);                 /* mov dl, [eax] */
            ii(0x1012_38cf, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x1012_38d2, 2); cmp(dl, memb[ds, eax]);                 /* cmp dl, [eax] */
            ii(0x1012_38d4, 2); if(jnz(0x1012_38de, 8)) goto l_0x1012_38de; /* jnz 0x101238de */
            ii(0x1012_38d6, 3); mov(eax, memd[ss, ebp - 24]);           /* mov eax, [ebp-0x18] */
            ii(0x1012_38d9, 3); cmp(eax, memd[ss, ebp - 12]);           /* cmp eax, [ebp-0xc] */
            ii(0x1012_38dc, 2); if(jb(0x1012_38e0, 2)) goto l_0x1012_38e0; /* jb 0x101238e0 */
        l_0x1012_38de:
            ii(0x1012_38de, 2); jmp(0x1012_38f4, 0x14); goto l_0x1012_38f4; /* jmp 0x101238f4 */
        l_0x1012_38e0:
            ii(0x1012_38e0, 3); mov(eax, memd[ss, ebp - 24]);           /* mov eax, [ebp-0x18] */
            ii(0x1012_38e3, 3); inc(memd[ss, ebp - 24]);                /* inc dword [ebp-0x18] */
            ii(0x1012_38e6, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x1012_38e9, 3); inc(memd[ss, ebp - 16]);                /* inc dword [ebp-0x10] */
            ii(0x1012_38ec, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1012_38ef, 3); inc(memd[ss, ebp - 8]);                 /* inc dword [ebp-0x8] */
            ii(0x1012_38f2, 2); jmp(0x1012_38ca, -0x2a); goto l_0x1012_38ca; /* jmp 0x101238ca */
        l_0x1012_38f4:
            ii(0x1012_38f4, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x1012_38f7, 2); mov(al, memb[ds, eax]);                 /* mov al, [eax] */
            ii(0x1012_38f9, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1012_38fe, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1012_3900, 6); if(jnz(0x1012_3990, 0x8a)) goto l_0x1012_3990; /* jnz 0x10123990 */
        l_0x1012_3906:
            ii(0x1012_3906, 3); mov(eax, memd[ss, ebp - 24]);           /* mov eax, [ebp-0x18] */
            ii(0x1012_3909, 3); cmp(eax, memd[ss, ebp - 12]);           /* cmp eax, [ebp-0xc] */
            ii(0x1012_390c, 2); if(jae(0x1012_3916, 8)) goto l_0x1012_3916; /* jae 0x10123916 */
            ii(0x1012_390e, 3); mov(eax, memd[ss, ebp - 24]);           /* mov eax, [ebp-0x18] */
            ii(0x1012_3911, 3); cmp(memb[ds, eax], 0x3d);               /* cmp byte [eax], 0x3d */
            ii(0x1012_3914, 2); if(jnz(0x1012_3918, 2)) goto l_0x1012_3918; /* jnz 0x10123918 */
        l_0x1012_3916:
            ii(0x1012_3916, 2); jmp(0x1012_3927, 0xf); goto l_0x1012_3927; /* jmp 0x10123927 */
        l_0x1012_3918:
            ii(0x1012_3918, 3); mov(eax, memd[ss, ebp - 24]);           /* mov eax, [ebp-0x18] */
            ii(0x1012_391b, 2); mov(al, memb[ds, eax]);                 /* mov al, [eax] */
            ii(0x1012_391d, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1012_3922, 3); cmp(eax, 0xd);                          /* cmp eax, 0xd */
            ii(0x1012_3925, 2); if(jnz(0x1012_3929, 2)) goto l_0x1012_3929; /* jnz 0x10123929 */
        l_0x1012_3927:
            ii(0x1012_3927, 2); jmp(0x1012_3937, 0xe); goto l_0x1012_3937; /* jmp 0x10123937 */
        l_0x1012_3929:
            ii(0x1012_3929, 3); mov(eax, memd[ss, ebp - 24]);           /* mov eax, [ebp-0x18] */
            ii(0x1012_392c, 3); inc(memd[ss, ebp - 24]);                /* inc dword [ebp-0x18] */
            ii(0x1012_392f, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1012_3932, 3); inc(memd[ss, ebp - 8]);                 /* inc dword [ebp-0x8] */
            ii(0x1012_3935, 2); jmp(0x1012_3906, -0x31); goto l_0x1012_3906; /* jmp 0x10123906 */
        l_0x1012_3937:
            ii(0x1012_3937, 3); mov(eax, memd[ss, ebp - 24]);           /* mov eax, [ebp-0x18] */
            ii(0x1012_393a, 3); cmp(eax, memd[ss, ebp - 12]);           /* cmp eax, [ebp-0xc] */
            ii(0x1012_393d, 2); if(jae(0x1012_3947, 8)) goto l_0x1012_3947; /* jae 0x10123947 */
            ii(0x1012_393f, 3); mov(eax, memd[ss, ebp - 24]);           /* mov eax, [ebp-0x18] */
            ii(0x1012_3942, 3); cmp(memb[ds, eax], 0x3d);               /* cmp byte [eax], 0x3d */
            ii(0x1012_3945, 2); if(jz(0x1012_3949, 2)) goto l_0x1012_3949; /* jz 0x10123949 */
        l_0x1012_3947:
            ii(0x1012_3947, 2); jmp(0x1012_3963, 0x1a); goto l_0x1012_3963; /* jmp 0x10123963 */
        l_0x1012_3949:
            ii(0x1012_3949, 3); mov(eax, memd[ss, ebp - 24]);           /* mov eax, [ebp-0x18] */
            ii(0x1012_394c, 3); inc(memd[ss, ebp - 24]);                /* inc dword [ebp-0x18] */
            ii(0x1012_394f, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1012_3952, 3); inc(memd[ss, ebp - 8]);                 /* inc dword [ebp-0x8] */
            ii(0x1012_3955, 3); mov(eax, memd[ss, ebp - 24]);           /* mov eax, [ebp-0x18] */
            ii(0x1012_3958, 3); mov(edx, memd[ss, ebp + 20]);           /* mov edx, [ebp+0x14] */
            ii(0x1012_395b, 6); mov(memd[ds, edx + 160], eax);          /* mov [edx+0xa0], eax */
            ii(0x1012_3961, 2); jmp(0x1012_3970, 0xd); goto l_0x1012_3970; /* jmp 0x10123970 */
        l_0x1012_3963:
            ii(0x1012_3963, 3); mov(eax, memd[ss, ebp + 20]);           /* mov eax, [ebp+0x14] */
            ii(0x1012_3966, 10); mov(memd[ds, eax + 160], 0);           /* mov dword [eax+0xa0], 0x0 */
        l_0x1012_3970:
            ii(0x1012_3970, 3); mov(eax, memd[ss, ebp - 20]);           /* mov eax, [ebp-0x14] */
            ii(0x1012_3973, 3); mov(edx, memd[ss, ebp + 20]);           /* mov edx, [ebp+0x14] */
            ii(0x1012_3976, 6); mov(memd[ds, edx + 156], eax);          /* mov [edx+0x9c], eax */
            ii(0x1012_397c, 3); mov(eax, memd[ss, ebp + 20]);           /* mov eax, [ebp+0x14] */
            ii(0x1012_397f, 10); mov(memd[ds, eax + 164], 0);           /* mov dword [eax+0xa4], 0x0 */
            ii(0x1012_3989, 7); mov(memd[ss, ebp - 4], 1);              /* mov dword [ebp-0x4], 0x1 */
        l_0x1012_3990:
            ii(0x1012_3990, 4); cmp(memd[ss, ebp - 4], 0);              /* cmp dword [ebp-0x4], 0x0 */
            ii(0x1012_3994, 2); if(jnz(0x1012_39bd, 0x27)) goto l_0x1012_39bd; /* jnz 0x101239bd */
        l_0x1012_3996:
            ii(0x1012_3996, 3); mov(eax, memd[ss, ebp - 24]);           /* mov eax, [ebp-0x18] */
            ii(0x1012_3999, 3); cmp(eax, memd[ss, ebp - 12]);           /* cmp eax, [ebp-0xc] */
            ii(0x1012_399c, 2); if(jae(0x1012_39ad, 0xf)) goto l_0x1012_39ad; /* jae 0x101239ad */
            ii(0x1012_399e, 3); mov(eax, memd[ss, ebp - 24]);           /* mov eax, [ebp-0x18] */
            ii(0x1012_39a1, 2); mov(al, memb[ds, eax]);                 /* mov al, [eax] */
            ii(0x1012_39a3, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1012_39a8, 3); cmp(eax, 0xa);                          /* cmp eax, 0xa */
            ii(0x1012_39ab, 2); if(jnz(0x1012_39af, 2)) goto l_0x1012_39af; /* jnz 0x101239af */
        l_0x1012_39ad:
            ii(0x1012_39ad, 2); jmp(0x1012_39bd, 0xe); goto l_0x1012_39bd; /* jmp 0x101239bd */
        l_0x1012_39af:
            ii(0x1012_39af, 3); mov(eax, memd[ss, ebp - 24]);           /* mov eax, [ebp-0x18] */
            ii(0x1012_39b2, 3); inc(memd[ss, ebp - 24]);                /* inc dword [ebp-0x18] */
            ii(0x1012_39b5, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1012_39b8, 3); inc(memd[ss, ebp - 8]);                 /* inc dword [ebp-0x8] */
            ii(0x1012_39bb, 2); jmp(0x1012_3996, -0x27); goto l_0x1012_3996; /* jmp 0x10123996 */
        l_0x1012_39bd:
            ii(0x1012_39bd, 3); mov(eax, memd[ss, ebp - 24]);           /* mov eax, [ebp-0x18] */
            ii(0x1012_39c0, 3); cmp(eax, memd[ss, ebp - 12]);           /* cmp eax, [ebp-0xc] */
            ii(0x1012_39c3, 2); if(jae(0x1012_39cb, 6)) goto l_0x1012_39cb; /* jae 0x101239cb */
            ii(0x1012_39c5, 3); mov(eax, memd[ss, ebp - 24]);           /* mov eax, [ebp-0x18] */
            ii(0x1012_39c8, 3); inc(memd[ss, ebp - 24]);                /* inc dword [ebp-0x18] */
        l_0x1012_39cb:
            ii(0x1012_39cb, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1012_39ce, 3); inc(memd[ss, ebp - 8]);                 /* inc dword [ebp-0x8] */
            ii(0x1012_39d1, 4); cmp(memd[ss, ebp - 4], 0);              /* cmp dword [ebp-0x4], 0x0 */
            ii(0x1012_39d5, 2); if(jnz(0x1012_39df, 8)) goto l_0x1012_39df; /* jnz 0x101239df */
            ii(0x1012_39d7, 3); mov(eax, memd[ss, ebp - 24]);           /* mov eax, [ebp-0x18] */
            ii(0x1012_39da, 3); cmp(eax, memd[ss, ebp - 12]);           /* cmp eax, [ebp-0xc] */
            ii(0x1012_39dd, 2); if(jb(0x1012_39e1, 2)) goto l_0x1012_39e1; /* jb 0x101239e1 */
        l_0x1012_39df:
            ii(0x1012_39df, 2); jmp(0x1012_39e9, 8); goto l_0x1012_39e9; /* jmp 0x101239e9 */
        l_0x1012_39e1:
            ii(0x1012_39e1, 3); mov(eax, memd[ss, ebp - 24]);           /* mov eax, [ebp-0x18] */
            ii(0x1012_39e4, 3); cmp(memb[ds, eax], 0x5b);               /* cmp byte [eax], 0x5b */
            ii(0x1012_39e7, 2); if(jnz(0x1012_39eb, 2)) goto l_0x1012_39eb; /* jnz 0x101239eb */
        l_0x1012_39e9:
            ii(0x1012_39e9, 2); jmp(0x1012_39f0, 5); goto l_0x1012_39f0; /* jmp 0x101239f0 */
        l_0x1012_39eb:
            ii(0x1012_39eb, 5); jmp(0x1012_389c, -0x154); goto l_0x1012_389c; /* jmp 0x1012389c */
        l_0x1012_39f0:
            ii(0x1012_39f0, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1012_39f3, 3); mov(memd[ss, ebp - 28], eax);           /* mov [ebp-0x1c], eax */
            ii(0x1012_39f6, 3); mov(eax, memd[ss, ebp - 28]);           /* mov eax, [ebp-0x1c] */
            ii(0x1012_39f9, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1012_39fb, 1); pop(ebp);                               /* pop ebp */
            ii(0x1012_39fc, 1); pop(edi);                               /* pop edi */
            ii(0x1012_39fd, 1); pop(esi);                               /* pop esi */
            ii(0x1012_39fe, 1); pop(ebx);                               /* pop ebx */
            ii(0x1012_39ff, 1); ret();                                  /* ret */
        }

#endif
        
        private HighLevelEngine Decode(MethodInfoDto mi)
        {
            var method = LowLevelEngine.GetMethod(mi);

            var hl = new HighLevelEngine(method.Instructions.OfType<CSharpInstruction>().ToList());
            hl.Decode();
            return hl;
        }
    }
}